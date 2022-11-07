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
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitSignupForm(object sender, EventArgs e)
        {
            try
            {
                // get text inputs
                string fname = fnameInput.Text;
                string lname = lnameInput.Text;
                string address = addressInput.Text;
                string postalCode = postalCodeInput.Text;
                string city = cityInput.Text;
                string province = provinceInput.Text;
                int ccNumber = Int32.Parse(ccNumberInput.Text);

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

                
                // still need to generate customer ID (display in above message box or display a new one)
                
            }
            catch (FormatException) // raise error if CC is inputted as string
            {
                MessageBox.Show("Invalid credit card number, please try again", "Registration Failed");
            }

            this.Close();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
