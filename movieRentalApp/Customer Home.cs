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
        public Customer_Home2()
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


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void getMovieResults(object sender, EventArgs e)
        {
            var searchResults = new Customer_Search_Results();
            searchResults.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rateMovie(object sender, EventArgs e)
        {
            var ratingMenu = new Rate_Movie();
            ratingMenu.Show();
        }

        private void placeOrder(object sender, EventArgs e)
        {
            string movieName = movieRentalInput.Text;
            MessageBox.Show(String.Format("Added {0} to rental queue\n" +
                                          "Return date: 2 weeks from now", movieName), movieName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void accountInfo_Click(object sender, EventArgs e)
        {

        }

        private void allowAcctEdits(object sender, EventArgs e)
        {
            this.custFName.ReadOnly = false;
            this.custLName.ReadOnly = false;
            this.custAddress.ReadOnly = false;
            this.custCity.ReadOnly = false;

        }

        private void saveAccInfoUpdates(object sender, EventArgs e)
        {
            this.custFName.ReadOnly = true;
            this.custLName.ReadOnly = true;
            this.custAddress.ReadOnly = true;
            this.custCity.ReadOnly = true;
        }
    }
}
