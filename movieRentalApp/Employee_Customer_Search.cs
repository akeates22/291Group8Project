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
    public partial class Employee_Customer_Search : Form
    {
        public string connectionString;
        public string CID;

        public Employee_Customer_Search(string connectionString, string CID)
        {
            this.connectionString = connectionString;
            this.CID = CID;
            InitializeComponent();
        }

        public void getResults()
        {
            string query = "select * from customers where accountNum = " + CID + ";";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                SqlCommand cmd = new SqlCommand(query, myConnection);
                SqlDataReader dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get customer information, please try again later");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
