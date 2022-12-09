using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            updateCustTable("select * from customers");
            this.contentBox.SelectTab(2);
        }

        private void updateCustTable(string query)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            if (String.IsNullOrWhiteSpace(query)) { query = "select * from customers"; }
            try
            {
                // remove existing items before displaying updated data
                this.listView1.Items.Clear();

                myConnection.Open();
                SqlCommand cmd = new SqlCommand(query, myConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string ID = dr.GetDecimal(0).ToString();
                    string subType = dr.GetString(1);
                    string fname = dr.GetString(2);
                    string lname = dr.GetString(3);
                    string addr = dr.GetString(4);
                    string city = dr.GetString(5);
                    string prov = dr.GetString(6);
                    string postal = dr.GetString(7);
                    string phone = dr.GetString(8);
                    string email = dr.GetString(9);
                    string startDate = dr.GetString(10);
                    string ccNum = dr.GetString(11);

                    // adding empty string to first column (zero-width) avoids weird formatting issues
                    string[] vals = {"", ID, subType, fname, lname, addr, city, prov,
                                     postal, phone, email, startDate, ccNum};
                    ListViewItem row = new ListViewItem(vals);
                    this.listView1.Items.Add(row);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get customer data, please try again later");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();
        }

        private void filterCustSearch(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            string phone = textBox3.Text;
            string email = textBox4.Text;
            string subType = comboBox2.GetItemText(comboBox2.SelectedItem);

            string[] cols = { "firstName", "lastName", "phone", "email", "subType" };
            string[] filters = { fname, lname, phone, email, subType };

            string baseQuery = "";
            int i;

            // first 'where' constraint wont require 'and' keyword
            for (i = 0; i < cols.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(filters[i]))
                {
                    baseQuery += "select * from customers where " +
                                       cols[i] + " = '" + filters[i] + "'";
                    break;
                }
            }

            // check subsequent filters for non-empty inputs
            // only executes if a non-null str was found before last position
            for (int j = i + 1; j < cols.Length; j++)
            {
                if (!String.IsNullOrWhiteSpace(filters[j]))
                {
                    baseQuery += " and " + cols[j] + " = '" + filters[j] + "'";
                }
            }
            updateCustTable(baseQuery);
        }
        private void showCustInfo(object sender, EventArgs e)
        {
            string CID = this.CIDinput.Text;
            // check for blank inputs or non-numbers
            if (String.IsNullOrWhiteSpace(CID) || !CID.All(char.IsDigit))
            {
                MessageBox.Show("Invalid customer ID, please try again");
                return;
            }
            Employee_Customer_Search searchResults = new Employee_Customer_Search(connectionString, CID);
            searchResults.Show();
            searchResults.getResults();
        }

        private void showEmpMovieSearch(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(0);
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
    }
}
