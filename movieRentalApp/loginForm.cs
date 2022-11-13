using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieRentalApp
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitLoginForm(object sender, EventArgs e)
        {
            string fname = loginFnameInput.Text;
            string lname = loginLnameInput.Text;
            try
            {
                int CID = Int32.Parse(custID.Text);
            }
            // only numbers allowed for customer id
            catch (FormatException)
            {
                MessageBox.Show("Invalid Customer ID, please try again", "Login Failed");
                return;
            }

            // check if user inputs are valid by looking at customers table in database
            // for now, users can only login with pre-set admin credentials
            if (fname == "admin" && lname == "test" && custID.Text == "123")
            {
                var mainMenu = new customerHome();
                mainMenu.Show();
            }

        }
    }
}
