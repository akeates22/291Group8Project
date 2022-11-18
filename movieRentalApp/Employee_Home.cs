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
    public partial class Employee_Home : Form
    {
        public Employee_Home()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void approveRentals(object sender, EventArgs e)
        {
            MessageBox.Show("Rentals Approved!");
        }

        private void showEmpInfo(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(3);
        }

        private void showEmpCustSearch(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(0);
        }

        private void showEmpMovieSearch(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(2);
        }

        private void showApproveRentals(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(1);
        }
    }
}
