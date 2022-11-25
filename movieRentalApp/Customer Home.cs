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
    public partial class Customer_Home2 : Form
    {
        public Customer_Home2(string ID)
        {
            InitializeComponent();

        }

        private void custMovieSearch(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(0);
        }

        private void showCurrentRentals(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(1);
        }

        private void showRentalHistory(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(2);
        }

        private void showCustRatings(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(3);
        }
        private void showAccInfo(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(4);
        }

        private void orderMenu(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(5);
        }


        private void getMovieResults(object sender, EventArgs e)
        {
            var searchResults = new Customer_Search_Results();
            searchResults.Show();
        }

        private void rateMovie(object sender, EventArgs e)
        {
            var ratingMenu = new Rate_Movie();
            ratingMenu.Show();
        }

        private void rateActor(object sender, EventArgs e)
        {
            var actorRating = new Rate_Actor();
            actorRating.Show();
        }

        private void placeOrder(object sender, EventArgs e)
        {
            string movieName = rentalTitle.Text;
            string startDate = rentalDate.Text;
            string returnDate = (DateTime.Parse(startDate).AddDays(14)).ToString();

            MessageBox.Show(String.Format("Successfully reserved {0} for rental on {1}\n" +
                                          "Order ID: 12345\n" +
                                          "Return date: {2}", 
                                          movieName, startDate, returnDate), "Submission Received");
        }

        private void allowAcctEdits(object sender, EventArgs e)
        {
            this.custFName.ReadOnly = false;
            this.custLName.ReadOnly = false;
            this.custAddress.ReadOnly = false;
            this.custCity.ReadOnly = false;
            this.custProvince.ReadOnly = false;
            this.custPostalCode.ReadOnly = false;
            this.custPhone.ReadOnly = false;
            this.custEmail.ReadOnly = false;

        }

        private void saveAccInfoUpdates(object sender, EventArgs e)
        {
            this.custFName.ReadOnly = true;
            this.custLName.ReadOnly = true;
            this.custAddress.ReadOnly = true;
            this.custCity.ReadOnly = true;
            this.custProvince.ReadOnly = true;
            this.custPostalCode.ReadOnly = true;
            this.custPhone.ReadOnly = true;
            this.custEmail.ReadOnly = true;
        }
    }
}
