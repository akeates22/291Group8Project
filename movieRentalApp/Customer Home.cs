using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieRentalApp
{
    public partial class Customer_Home2 : Form
    {

        public SqlConnection sqlConnection;
        public SqlCommand cmd;
        public String CID;
        public string connectionString;

        public Customer_Home2(string connectionString, string CID)
        {
            this.CID = CID;
            this.connectionString = connectionString;
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

            SqlConnection myConnection = new SqlConnection(connectionString);
            

            try
            {
                myConnection.Open();

                string getInfo = "select firstName, lastName, city, [state/province], [address], " +
                                 "[zip/postalCode], phone, email, subType, rating from customers C " +
                                 "where C.accountNum = " + this.CID + ";";

                SqlCommand cmd = new SqlCommand(getInfo, myConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    MessageBox.Show("Error finding your account, please try again later");
                }

                this.custFName.Text   = dr.GetString(0);
                this.custLName.Text   = dr.GetString(1);
                this.custCity.Text    = dr.GetString(2);
                this.custProv.Text    = dr.GetString(3);
                this.custAddress.Text = dr.GetString(4);
                this.custPostal.Text  = dr.GetString(5);
                this.custPhone.Text   = (dr.GetDecimal(6)).ToString();
                this.custEmail.Text   = dr.GetString(7);
                this.custSubPlan.Text = dr.GetString(8);

                switch (this.custSubPlan.Text) 
                {
                    case "Basic":
                        this.custFees.Text = "$5 / month";
                        this.custRentalLimit.Text = "8 / month";
                        break;
                    case "Premium":
                        this.custFees.Text = "$10 / month";
                        this.custRentalLimit.Text = "12 / month";
                        break;
                    case "Premium Plus":
                        this.custFees.Text = "$15 / month";
                        this.custRentalLimit.Text = "20 / month";
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving information, please try again later");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();

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
            this.custProv.ReadOnly = false;
            this.custPostal.ReadOnly = false;
            this.custPhone.ReadOnly = false;
            this.custEmail.ReadOnly = false;

        }

        private void saveAccInfoUpdates(object sender, EventArgs e)
        {
            this.custFName.ReadOnly = true;
            this.custLName.ReadOnly = true;
            this.custAddress.ReadOnly = true;
            this.custCity.ReadOnly = true;
            this.custProv.ReadOnly = true;
            this.custPostal.ReadOnly = true;
            this.custPhone.ReadOnly = true;
            this.custEmail.ReadOnly = true;
        }
    }
}
