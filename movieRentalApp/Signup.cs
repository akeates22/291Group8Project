using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace movieRentalApp
{
    public partial class Signup : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand cmd;
        public Signup()
        {
            InitializeComponent();
        }

        private void submitSignupForm(object sender, EventArgs e)
        {
            // get text inputs
            string fname = signupFnameInput.Text;
            string lname = signupLnameInput.Text;
            string address = addressInput.Text;
            string postalCode = postalCodeInput.Text;
            string city = cityInput.Text;
            string province = provinceInput.Text;
            string email = emailInput.Text;
            
            DateTime dt = DateTime.Now;
            string creationDate = dt.ToShortDateString();

            try
            {
                int ccNumber = Int32.Parse(ccNumberInput.Text);
                int phone = Int32.Parse(phoneInput.Text);
            }
            
            catch 
            {
                MessageBox.Show("Invalid entries, please try again", "Registration Failed");
                this.Close();
                return;
            }

            // get subscription plan
            string accType = "";
            if (basicSubButton.Checked)
                accType = "Basic";
            else if (premSubButton.Checked)
                accType = "Premium";
            else if (premPlusSubButton.Checked)
                accType = "Premium Plus";

            // make sure no inputs are blank
            string[] inputs = { fname, lname, address, postalCode, city, province, email, accType };
            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Invalid entries, please fill out all fields", "Registration Failed");
                    this.Close();
                    return;
                }

            }

            string connectionString = "Server = ANDREWS-PC; Database = 291Project; Trusted_Connection = Yes";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                // connect to database
                myConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = myConnection;

                // look at last customer added to the database, add 1 to their ID
                // for now, just use a hardcoded ID
                int CID = 1;

                cmd.CommandText = "insert into customers values (" + CID.ToString() + ",'" + accType + "','" + fname + 
                                  "','" + lname + "','" + address + "','" + city + "','" + province + "','" + 
                                  postalCode + "'," + phoneInput.Text + ",'" + email + "','" + creationDate + "'," + 
                                  ccNumberInput.Text + "," + "0.0" + ")";

                cmd.ExecuteNonQuery();
                myConnection.Close();

                MessageBox.Show(String.Format("Registration successful, your Customer ID is: {0}", CID), "Registration Successful");
                Login loginMenu = new Login(CID.ToString());
                loginMenu.Show();
                this.Close();

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to register user, try again later", "Registration Error");
                MessageBox.Show(ex.Message);

                myConnection.Close();
                this.Close();
                return;
            }

            
        }
    }
}
