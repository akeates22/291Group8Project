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

namespace movieRentalApp
{
    public partial class Signup : Form
    {
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

            try
            {
                int ccNumber = Int32.Parse(ccNumberInput.Text);
            }
            
            catch {
                MessageBox.Show("Invalid credit card number, please try again", "Registration Failed");
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
            string[] inputs = { fname, lname, address, postalCode, city, province, accType };
            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Invalid entries, please fill out all fields", "Registration Failed");
                    this.Close();
                    return;
                }

            }

            // all inputs are valid
            MessageBox.Show(String.Format("Successfully registered {0} {1} for a {2} subscription\n" +
                         "Return to start menu to login", fname, lname, accType), "Registration Complete");

            // generate & display customer ID
            Random newID = new Random();
            int CID = newID.Next(1, 1000);
            MessageBox.Show(String.Format("Your Customer id is {0}\nDONT FORGET THIS!", CID));

            Login newLogin = new Login(Convert.ToString(CID));
            newLogin.Show();


            this.Close();

        }
    }
}
