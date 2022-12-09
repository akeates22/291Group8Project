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

namespace movieRentalApp
{
    public partial class Employee_Home : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand cmd;
        public String ID;
        public string connectionString;
        public Employee_Home(string connectionString, string ID)
        {
            this.connectionString = connectionString;
            this.ID = ID;
            InitializeComponent();
        }

        private void re(object sender, EventArgs e)
        {
            Signup register = new Signup(connectionString);
            register.Show();
        }

        private void approveRentals(object sender, EventArgs e)
        {

        }

        private void showEmpInfo(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(3);
        }

        private void showEmpCustSearch(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(0);
        }

        private void showEmpMovieSearch(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(2);
        }

        private void showApproveRentals(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(1);
        }

        private void manageMoviesMain_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

    }
}
