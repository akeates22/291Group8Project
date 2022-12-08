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
    public partial class Login : Form
    {
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


            // check if user inputs are valid by looking at database
            // Customer IDs are 5 digits , Employee IDs are 9 (use SSN)
            // ref: https://stackoverflow.com/questions/14051672/how-to-verify-datatype-before-entering-into-the-table

            // for now, these are the only valid logins for customer and employee
            if (fname == "admin" && lname == "test" && ID == "12345")
            {
                var mainMenu = new Customer_Home2();
                mainMenu.Show();
                this.Close();
            }
            else if (fname == "admin" && lname == "test" && ID == "123456789")
            {
                //show employee home screen
                var employeeMenu = new Employee_Home();
            }
            else
            {
                MessageBox.Show("Invalid Credentials, please try again");
            }

        }
    }
}
