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
    public partial class customerHome : Form
    {
        public customerHome()
        {
            InitializeComponent();

            // create function to display users name in header
            // either check database with user's ID, or pass their name as a parameter
            // from the login screen (probably a better option)
            // ref: https://stackoverflow.com/questions/48778018/c-update-label-text-on-windows-forms-from-console-application


        }

        private void movieSearchClick(object sender, EventArgs e)
        {

        }

        private void movieRatingsClick(object sender, EventArgs e)
        {

        }

        private void custSuggestionsClick(object sender, EventArgs e)
        {

        }

        private void rentalHistoryClick(object sender, EventArgs e)
        {

        }

        private void currentRentalsClick(object sender, EventArgs e)
        {

        }

        private void accountInfoClick(object sender, EventArgs e)
        {
            var accInfo = new customerAccInfo();
            accInfo.Show();
        }
    }
}
