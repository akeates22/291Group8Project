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
            this.currentRentalsList.Items.Clear();
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                string getRentals = "select M.movieName, O.dateTo, C.copyID, C.type " +
                                    "from movies M, orders O, copies C where M.movieID = O.movieID " +
                                    "and O.copyID = C.copyID and O.accountNum = " + this.CID + 
                                    " and C.available = 'no';";

                SqlCommand cmd = new SqlCommand(getRentals, myConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string title = dr.GetString(0);
                    string date  = dr.GetDateTime(1).ToString("yyyy-MM-dd");
                    string ID    = dr.GetDecimal(2).ToString();
                    string type  = dr.GetString(3);

                    string[] vals = { title, date, ID, type };
                    ListViewItem row = new ListViewItem(vals);
                    this.currentRentalsList.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get current rentals, please try again later");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();
            this.contentBox.SelectTab(1);
        }

        private void showRentalHistory(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                string getHistory = "select M.movieName, O.dateFrom, O.copyID, C.type " +
                                    "from movies M, orders O, copies C " +
                                    "where M.movieID = O.movieID and O.copyID = C.copyID and " +
                                    "O.accountNum = " + this.CID + ";";

                SqlCommand cmd = new SqlCommand(getHistory, myConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string title = dr.GetString(0);
                    string date  = dr.GetDateTime(1).ToString("yyyy-MM-dd");
                    string ID    = dr.GetDecimal(2).ToString();
                    string type  = dr.GetString(3);

                    string[] vals = { title, date, ID, type };
                    ListViewItem row = new ListViewItem(vals);
                    this.listView1.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get rental history, please try again later");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();
            this.contentBox.SelectTab(2);
        }

        private void showCustRatings(object sender, EventArgs e)
        {
            this.listView2.Items.Clear();
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                string getRatings = "select distinct M.movieName, O.rating, min(O.dateFrom) " +
                                    "from movies M, orders O, copies C " +
                                    "where M.movieID = O.movieID and O.copyID = C.copyID and " +
                                    "O.rating is not null and O.accountNum = " + this.CID + " and " +
                                    "C.available = 'yes' group by M.movieName, O.rating;";

                SqlCommand cmd = new SqlCommand(getRatings, myConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string title = dr.GetString(0);
                    string rating = dr.GetDecimal(1).ToString();
                    string date = dr.GetDateTime(2).ToString("yyyy-MM-dd"); ;

                    string[] vals = { "", title, rating, date };

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
            string from    = "from movies M, copies C ";
            string where   = "where M.movieID = C.movieID and " +
                             "not exists (select * from orders where movieID = M.movieID and " +
                             "copyID = C.copyID and ('" + rentalDate + "' between dateFrom and dateTo)) ";
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
            ratingMenu.getMovies();
            ratingMenu.Show();
        }

        private void updateRatings(object sender, EventArgs e)
        {
            var updateMenu = new updateRating(connectionString, CID);
            updateMenu.getMovies();
            updateMenu.Show();  
        }

        private void placeOrder(object sender, EventArgs e)
        {
            string title = rentalTitle.Text;
            string format = this.rentalFormat.GetItemText(this.rentalFormat.SelectedItem);
            string startDate = rentalDate.Value.ToString("yyyy-MM-dd");
            string returnDate = (DateTime.Parse(startDate).AddDays(14)).ToString("yyyy-MM-dd");

            // check that no fields are blank
            if (String.IsNullOrWhiteSpace(title) || String.IsNullOrWhiteSpace(format))
            {
                MessageBox.Show("Invalid entry, please fill out all fields and try again");
                return;
            }

            // check that customer hasnt reached rental limit
            if (!this.checkRentalLimit()) { return; }

            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();

                // get next order ID
                SqlCommand cmd = new SqlCommand("select ISNULL(max(orderID), 0) from orders", myConnection);
                string newOrderID = (Convert.ToInt32(cmd.ExecuteScalar()) + 1).ToString();

                // get copy ID 
                string baseCopyIDQuery = "select min(C.copyID) from movies M, copies C " +
                                         "where M.movieID = C.movieID and " +
                                         "M.movieName = '" + title + "' and C.type = '" + format + "' and ";

                // requesting rental today or in the future requires different queries
                if (startDate == DateTime.Today.ToString("yyyy-MM-dd"))
                {
                    cmd.CommandText = (baseCopyIDQuery + "C.available = 'yes';");
                } else {
                    string checkDate = "not exists (select * from orders where movieID = M.movieID and copyID = C.copyID " +
                                       "and ('" + startDate + "' between dateFrom and dateTo));";
                    cmd.CommandText = (baseCopyIDQuery + checkDate);
                }
                object copyID = cmd.ExecuteScalar();

                // get movie ID 
                cmd.CommandText = "select movieID from movies where movieName = '" + title + "';";
                object movieID = cmd.ExecuteScalar();


                if (copyID.Equals(DBNull.Value) || movieID.Equals(DBNull.Value))
                {
                    MessageBox.Show("Unable to find requested movie, try using a different format or rental date");
                    myConnection.Close();
                    return;
                }

                // movie needs to be returned before next reserved rental date, up to maximum of 2 weeks
                cmd.CommandText = "select min(dateFrom) from Orders where copyID = " + copyID + " and " +
                                  "datediff(day, dateFrom, '" + startDate + "') < 14;";
                object nextRental = cmd.ExecuteScalar();
                if (!nextRental.Equals(DBNull.Value))
                {
                    returnDate = ((DateTime)nextRental).ToString("yyyy-MM-dd");
                }

                // update orders table
                cmd.CommandText = "insert into orders values (" + newOrderID + ", " + copyID.ToString() + 
                                  ", " + movieID.ToString() + ", null," + this.CID + ", '" + startDate + 
                                  "', '" + returnDate + "', null);";
                cmd.ExecuteNonQuery();

                // set ordered movie to unavailable if rental date was today
                if (startDate == DateTime.Today.ToString("yyyy-MM-dd"))
                {
                    cmd.CommandText = "update copies set available = 'no' where copyID = " + copyID + ";";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("unexpected error occured, please try again later");
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Order has been submitted, please pick up your copy on " + startDate + 
                            "\nYour return date is: " + returnDate);
            myConnection.Close();
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

        private Boolean checkRentalLimit()
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
                string getLimit = "select S.movieLimit from subscriptions S, customers C " +
                                "where S.type = C.subType and C.accountNum = '" + this.CID + "';";
                SqlCommand cmd = new SqlCommand(getLimit, myConnection);
                int limit = Convert.ToInt32(cmd.ExecuteScalar());

                int currMonth = DateTime.Now.Month;
                cmd.CommandText = "select count(*) from orders where " + "accountNum = '" + this.CID + 
                                  "' and month(dateFrom) = " + currMonth + ";";
                int monthRentals = Convert.ToInt32(cmd.ExecuteScalar()); 

                if (monthRentals >= limit)
                {
                    MessageBox.Show("Unable to place order, you've reached your rental limit for this month");
                    myConnection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to place order, please try again later");
                MessageBox.Show(ex.Message);
                myConnection.Close();
                return false;
            }
            myConnection.Close();
            return true;
        }

    }

}
