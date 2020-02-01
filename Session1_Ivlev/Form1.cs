using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1_Ivlev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer tmrShow = new Timer();

        void unlockForm(object sender, EventArgs e)
        {
            tmrShow.Stop();
            tmrShow.Tick -= new System.EventHandler(unlockForm);
            usernameTextBox.ReadOnly = false;
            passwordTextBox.ReadOnly = false;
            loginButton.Enabled = true;

            warningLabel.Text = tmrShow.ToString();
        }


        int countAttempt = 3;

        private async void loginButton_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;

            SqlConnection sqlConnection;

            string connectionPath = @"
                Data Source=localhost;
                Initial Catalog=Session2_Ivlev;
                Integrated Security=True;
                Connect Timeout=30;Encrypt=False;
                TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False";

            sqlConnection = new SqlConnection(connectionPath);
            await sqlConnection.OpenAsync();

            SqlDataReader sdr = null;

            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM [Users]", sqlConnection);


            try
            {
                sdr = await cmdSelect.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (usernameTextBox.Text == Convert.ToString(sdr["Email"]))
                    {

                        if (passwordTextBox.Text == Convert.ToString(sdr["Password"]))
                        {
                            switch (Convert.ToString(sdr["RoleID"]))
                            {
                                case "1":
                                    adminForm adm = new adminForm();
                                    adm.Show();
                                    this.Hide();

                                    break;

                                case "3":
                                    managerForm mng = new managerForm();
                                    mng.Show();
                                    this.Hide();

                                    break;
                            }
                        } else
                        {
                            warningLabel.Text = "Пароль неверный!";
                            warningLabel.Visible = true;

                            countAttempt--;
                        }
                    } else
                    {
                        warningLabel.Text = "Логин неверный!";
                        warningLabel.Visible = true;

                        countAttempt--;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (countAttempt == 0)
            {
                usernameTextBox.ReadOnly = true;
                passwordTextBox.ReadOnly = true;
                loginButton.Enabled = false;


                tmrShow.Interval = 10000;
                tmrShow.Tick += new System.EventHandler(unlockForm);
                tmrShow.Start();

                warningLabel.Visible = true;
                warningLabel.Text = "Авторизация заблокирована на 10 секунд!";
 
                countAttempt = 3;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
