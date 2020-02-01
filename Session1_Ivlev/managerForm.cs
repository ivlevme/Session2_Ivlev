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
    public partial class managerForm : Form
    {
        public managerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void managerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'session2_IvlevDataSet.Routes1' table. You can move, or remove it, as needed.
            this.routes1TableAdapter.Fill(this.session2_IvlevDataSet.Routes1);
            this.routesTableAdapter.Fill(this.session2_IvlevDataSet.Routes);
            this.airportsTableAdapter.Fill(this.session2_IvlevDataSet.Airports);
            this.schedulesTableAdapter.Fill(this.session2_IvlevDataSet.Schedules);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void managerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            importChangesFlight icf = new importChangesFlight();
            icf.Show();
            this.Hide();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
