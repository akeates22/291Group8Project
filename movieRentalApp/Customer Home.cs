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
            this.listView2.Items.Clear();
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                string getRatings = "select distinct M.movieName, O.rating, " +
                                    "concat(min(O.dateFrom), '  -  ', min(O.dateTo)) " +
                                    "from movies M, orders O, copies C " +
                                    "where M.movieID = O.movieID and O.copyID = C.copyID and " +
                                    "O.rating is not null and O.accountNum = " + this.CID + " and " +
                                    "C.available = 'yes' group by M.movieName, O.rating;";

                SqlCommand cmd = new SqlCommand(getRatings, myConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string title = dr.GetString(0);
                    string rating = dr.GetInt32(1).ToString();
                    string period = dr.GetString(2);

                    string[] vals = { "", title, rating, period };

                    ListViewItem row = new ListViewItem(vals);
                    this.listView2.Items.Add(row);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to load ratings, please try again later");
                MessageBox.Show(ex.Message);   
            }

            myConnection.Close();
            this.contentBox.SelectTab(3);
        }

        private void showAccInfo(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();

                string getInfo = "select firstName, lastName, city, [state/province], [address], " +
                                 "[zip/postalCode], phone, email, subType from customers C " +
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
                this.custPhone.Text   = dr.GetString(6);
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
            string title = this.title.Text;
            string starring = this.starring.Text;
            string rentalDate = chosenDate.Value.ToString("yyyy-MM-dd");
            string genre = this.genre.GetItemText(this.genre.SelectedItem);

            // these are the same regardless of inputs
            string select  = "select M.movieName, C.type, count(*) ";
            string from    = "from movies M, copies C, orders O";
            string where   = " where M.movieID = C.movieID and M.movieID = O.movieID and C.copyID = O.copyID " +
                             "and ('" + rentalDate + "' not between O.dateFrom and O.dateTo) ";
            string groupBy = "group by M.movieName, C.type;";

            if (!string.IsNullOrWhiteSpace(title))
            {
                where += "and M.movieName = '" + title + "' ";
            }
            if (!string.IsNullOrWhiteSpace(starring))
            {
                from += ", actors A, movies_in MI";
                where += "and M.movieID = MI.movieID and A.actorID = MI.actorID and " + 
                             "A.fullName = '" + starring + "' ";
            }
            if (!string.IsNullOrWhiteSpace(genre))
            {
                where += "and M.movieType = '" + genre + "' ";

            }
            
            string fullQuery = select + from + where + groupBy;
            MessageBox.Show(fullQuery);
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                SqlCommand cmd = new SqlCommand(fullQuery, myConnection);
                SqlDataReader queryResults = cmd.ExecuteReader();

                List<string> rowList = new List<string>();
                while (queryResults.Read())
                {
                    string row = queryResults.GetString(0) + "   " + queryResults.GetString(1) + "   " + 
                                 queryResults.GetInt32(2).ToString();
                    rowList.Add(row);
                }
                var searchResults = new Customer_Search_Results(rowList.ToArray());
                searchResults.Show();
                searchResults.DisplayResults();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to generate search results please try again later");
                MessageBox.Show(ex.Message);
            }

            myConnection.Close();
        }

        private void rateMovie(object sender, EventArgs e)
        {
            var ratingMenu = new Rate_Movie(connectionString, CID);
            ratingMenu.addMovies();
            ratingMenu.Show();
        }

        private void updateRatings(object sender, EventArgs e)
        {

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

            saveAccInfoChanges.Visible = true;
            cancelChanges.Visible = true;

        }

        private void saveAccInfoUpdates(object sender, EventArgs e)
        {
            // check validity of entries
            string fname = this.custFName.Text;
            string lname = this.custLName.Text;
            string city = this.custCity.Text;
            string prov = this.custProv.Text;
            string address = this.custAddress.Text;
            string postal = this.custPostal.Text;
            string email = this.custEmail.Text;
            string phone = this.custPhone.Text;

            // phone must be a number
            if (!phone.All(char.IsDigit)) { MessageBox.Show("Invalid phone number"); return; }


            // make sure no inputs are blank
            string[] inputs = { fname, lname, city, prov, address, postal, email };
            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Invalid entries, fields cannot be empty");
                    return;
                }
            }

            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
                string updateAcctInfo = "update customers set firstName = '" + fname + "', lastName = '" + lname + 
                                        "', address = '" + address + "', city = '" + city + "', [state/province] = '" + 
                                        prov + "', [zip/postalCode] = '" + postal + "', phone = '" + phone + "' " +
                                        ", email = '" + email + "' where accountNum = " + this.CID + ";";
                SqlCommand cmd = new SqlCommand(updateAcctInfo, myConnection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update account information, try again later");
                MessageBox.Show(ex.Message);
            }

            myConnection.Close();

            this.custFName.ReadOnly = true;
            this.custLName.ReadOnly = true;
            this.custAddress.ReadOnly = true;
            this.custCity.ReadOnly = true;
            this.custProv.ReadOnly = true;
            this.custPostal.ReadOnly = true;
            this.custPhone.ReadOnly = true;
            this.custEmail.ReadOnly = true;

            saveAccInfoChanges.Visible = false;
            cancelChanges.Visible = false;

        }

        private void cancelUpdates(object sender, EventArgs e)
        {
            showAccInfo(sender, e);

            this.custFName.ReadOnly = true;
            this.custLName.ReadOnly = true;
            this.custAddress.ReadOnly = true;
            this.custCity.ReadOnly = true;
            this.custProv.ReadOnly = true;
            this.custPostal.ReadOnly = true;
            this.custPhone.ReadOnly = true;
            this.custEmail.ReadOnly = true;

            saveAccInfoChanges.Visible = false;
            cancelChanges.Visible = false;
        }

        
    }
}
