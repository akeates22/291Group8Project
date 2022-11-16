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

        private void submitLoginForm(object sender, EventArgs e)
        {
            string fname = loginFnameInput.Text;
            string lname = loginLnameInput.Text;
            int CID = Int32.Parse(custID.Text);
            

            // check if user inputs are valid by looking at customers table in database
            // for now, users can only login with pre-set admin credentials
            if (fname == "admin" && lname == "test" && CID == 123)
            {
                var mainMenu = new customerHome();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials, please try again");
            }

        }
    }
}
