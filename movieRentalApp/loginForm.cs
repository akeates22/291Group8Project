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
            // check if user inputs are valid by looking at customers table in database

            // for now, all inputs return an invalid login
            MessageBox.Show("Invalid credentials, please try again", "Login Failed");


            // future testing: will need to allow logins to get to other menus

        }
    }
}
