using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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


        private void showEmpInfo(object sender, EventArgs e)
        {
            string query = "select firstName, lastName, address, city, [state/province], phone, startDay, hourlyRate " +
                           "from employees where SSN = " + ID + ";";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                SqlCommand cmd = new SqlCommand(query, myConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    MessageBox.Show("Unable to get employee information, please try again later");
                    myConnection.Close();
                    return;
                }
                textBox5.Text = dr.GetString(0);
                textBox6.Text = dr.GetString(1);
                textBox7.Text = dr.GetString(2);
                textBox8.Text = dr.GetString(3);
                textBox9.Text = dr.GetString(4);
                textBox10.Text = dr.GetDecimal(5).ToString();
                textBox11.Text = dr.GetString(6);
                textBox12.Text = dr.GetDecimal(7).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occured, please try again later");
                MessageBox.Show(ex.Message);

            }
            myConnection.Close();
            this.contentBox.SelectTab(1);
        }

        private void updateEmpButtonClick(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox9.ReadOnly = false;
            textBox10.ReadOnly = false;

            saveEmpInfoChanges.Visible = true;
            cancelEmpInfoChanges.Visible = true;
        }
        private void cancelEmpAcctChanges(object sender, EventArgs e)
        {
            showEmpInfo(sender, e);

            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;

            saveEmpInfoChanges.Visible = false;
            cancelEmpInfoChanges.Visible = false;
        }
        private void saveEmpAcctChanges(object sender, EventArgs e)
        {
            string fname = textBox5.Text;
            string lname = textBox6.Text;
            string addr = textBox7.Text;
            string city = textBox8.Text;
            string prov = textBox9.Text;
            string phone = textBox10.Text;

            if (!phone.All(char.IsDigit)) { MessageBox.Show("Invalid phone number"); return; }

            // make sure no inputs are blank
            string[] inputs = { fname, lname, addr, city, prov };
            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Invalid entries, fields cannot be empty");
                    return;
                }
            }

            string update = "update employees set firstName = '" + fname + "', lastName = '" + lname +
                            "', address = '" + addr + "', city = '" + city + "', [state/province] = '" +
                            prov + "', phone = " + phone + " where SSN = " + ID + ";";
            
            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
                SqlCommand cmd = new SqlCommand(update, myConnection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update employee information, please try again later");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();

            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;

            saveEmpInfoChanges.Visible = false;
            cancelEmpInfoChanges.Visible = false;
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

        private void employeeMovieData(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
                string query1 = "select M.movieName, C.copyID, C.type from movies M, copies C" +
                                " where M.movieID = C.movieID";

                SqlCommand cmd = new SqlCommand(query1, myConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(
                    dr["movieName"].ToString(),
                    dr["copyID"].ToString(),
                    dr["type"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get rental history, please try again later");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();
            this.contentBox.SelectTab(0);
        }

        private void showApproveRentals(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(1);
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                checkedListBox1.Items.Clear();
                con.Open();
                string show = "select M.movieName, O.copyID, O.accountNum " +
                              "from movies M, Orders O where " +
                              "M.movieID = O.movieID and O.employeeVerify is null";
                SqlCommand cmd = new SqlCommand(show, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    string copy = dr.GetDecimal(1).ToString();
                    string num = dr.GetDecimal(2).ToString();

                    string row = name + "\t\t" + copy + "\t" + num;

                    checkedListBox1.Items.AddRange(new object[] { row });
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to show orders");
                MessageBox.Show(ex.Message);
            }
            con.Close();
            this.contentBox.SelectTab(3);
        }

        private void approveRentals(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                string update = "UPDATE orders SET employeeVerify = '" + ID + "';";
                SqlCommand cmd = new SqlCommand(update, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                this.checkedListBox1.Items.Clear();
                MessageBox.Show("Rentals Approved!");
            }

            catch (Exception ex)
            {

                MessageBox.Show("Unable to approve Customer Rentals");
                MessageBox.Show(ex.Message);
            }
        }

    }
}
