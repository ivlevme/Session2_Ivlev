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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void adminForm_Load(object sender, EventArgs e)
        {

            string connectionPath = @"Data Source = localhost; 
                Initial Catalog = Session1_Ivlev; 
                Integrated Security = True; 
                Connect Timeout = 30; 
                Encrypt = False; 
                TrustServerCertificate = False; 
                ApplicationIntent = ReadWrite; 
                MultiSubnetFailover = False";
            SqlConnection sqlConnection = new SqlConnection(connectionPath);
            await sqlConnection.OpenAsync();
            SqlDataReader sdr = null;
            SqlCommand selectUsers = new SqlCommand("SELECT * FROM [Users]", sqlConnection);

            try
            {
                sdr = await selectUsers.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
            
                    dataGridView1.Rows.Add(Convert.ToString(sdr["Firstname"]), Convert.ToString(sdr["Lastname"]), Convert.ToString(sdr["Birthdate"]), Convert.ToString(sdr["RoleId"]), Convert.ToString(sdr["OfficeID"]));
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
