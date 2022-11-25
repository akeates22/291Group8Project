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
    public partial class Login : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand cmd;

        public Login(string ID = "")
        {
            InitializeComponent();
            IDinput.Text = ID;
        }

        private void submitLoginForm(object sender, EventArgs e)
        {
            // keep ID as string for now, check for valid data type inside sql query
            string fname = loginFnameInput.Text;
            string lname = loginLnameInput.Text;
            string ID = IDinput.Text;

            // connect to database & look for matching credentials 
            string connectionString = "Server = ANDREWS-PC; Database = 291Project; Trusted_Connection = Yes";
            SqlConnection myConnection = new SqlConnection(connectionString);

            if (ID.Length < 9) { this.customerLogin(myConnection, fname, lname, ID); }

            else if (ID.Length == 9) { this.employeeLogin(myConnection, fname, lname, ID); }
            
            else { MessageBox.Show("Invalid ID, please try again"); }

        }

        private void customerLogin(SqlConnection con, string fname, string lname, string ID)
        {

            try
            {
                con.Open();
                string checkForUser = "select firstName, lastName, accountNum from customers where " +
                                      "firstName = " + "'" + fname + "' and " + "lastName = " + "'" +
                                      lname + "' and " + "accountNum = " + ID;

                SqlCommand cmd = new SqlCommand(checkForUser, con);
                SqlDataReader dr = cmd.ExecuteReader();

                // no records matching user's inputs
                if (!dr.Read())
                {
                    MessageBox.Show("Unable to find user, please check your inputs and try again");
                    con.Close();
                }
                
                con.Close();   
                Customer_Home2 custHome = new Customer_Home2(ID);
                custHome.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occured, check your connection or try again later");
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void employeeLogin(SqlConnection con, string fname, string lname, string ID)
        {

            try
            {
                con.Open();
                string checkForUser = "select firstName, lastName, SSN from employees where " +
                                      "firstName = " + "'" + fname + "' and " + "lastName = " + "'" +
                                      lname + "' and " + "SSN = " + ID;

                SqlCommand cmd = new SqlCommand(checkForUser, con);
                SqlDataReader dr = cmd.ExecuteReader();

                // no records matching user's inputs
                if (!dr.Read())
                {
                    MessageBox.Show("Unable to find employee, please check your inputs and try again, or contact your manager");
                    con.Close();
                }

                con.Close();
                Employee_Home empHome = new Employee_Home(ID);
                empHome.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occured, check your connection and try again later, or contact tech support");
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }


}
