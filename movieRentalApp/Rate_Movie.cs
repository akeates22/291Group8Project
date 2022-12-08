using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieRentalApp
{
    public partial class Rate_Movie : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand cmd;
        public string connectionString;
        public string CID;
        public Rate_Movie(string connectionString, string CID)
        {
            this.connectionString = connectionString;
            this.CID = CID;  
            InitializeComponent();
        }

        public void getMovies()
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();

                string currDate = DateTime.Today.ToString("yyyy-MM-dd");
                // movies that customer has already rated
                string subQuery = "select distinct movieID from orders where " +
                                  "accountNum = " + this.CID + " and rating is not null";

                string query = "select distinct M.movieName from movies M, orders O, copies C " +
                               "where M.movieID = O.movieID and C.copyID = O.copyID and " +
                               "C.available = 'yes' and O.accountNum = " + this.CID + " and " +
                               "O.dateFrom <= '" + currDate + "' and M.movieID not in ( " + subQuery + " );";

                SqlCommand cmd = new SqlCommand(query, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                da.Fill(dt);

                if (dt.Tables[0].Rows.Count > 0)
                {
                    this.canRate.DataSource = dt.Tables[0];
                    this.canRate.DisplayMember = "movieName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get movies, please try again later");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();

        }
        private void postMovieRating(object sender, EventArgs e)
        {

            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                string selectedMovie = this.canRate.GetItemText(this.canRate.SelectedItem);
                int newRating = Int32.Parse(this.ratingChoice.Text);

                myConnection.Open();

                string subQuery = "select Top 1 O.orderID from Orders O, movies M " +
                                  "where O.movieID = M.movieID and O.accountNum = " + this.CID +
                                  " and M.movieName = '" + selectedMovie + "' order by O.dateFrom asc";
                string updateCmd = "update orders set rating = " + newRating + " where accountNum = " + this.CID +
                                   " and orderID in (" + subQuery + ");";

                SqlCommand cmd = new SqlCommand(updateCmd, myConnection);
                cmd.ExecuteNonQuery();
                myConnection.Close();

                MessageBox.Show("Rating added!");

                this.updateMovieAvg(selectedMovie, newRating);
                this.updateActorAvg(selectedMovie, newRating);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add rating, please try again later");
                MessageBox.Show(ex.Message);
                myConnection.Close();
            }
            this.Close();
        }

        private void updateMovieAvg(string movie, int newRating)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
                string getRatingCount = "select count(*) from orders O, movies M where M.movieId = O.movieID and " +
                                        "O.rating is not null;";
                SqlCommand cmd = new SqlCommand(getRatingCount, myConnection);
                int totalRatings = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "select rating from movies where movieName = '" + movie + "';";
                int currAvg = Convert.ToInt32(cmd.ExecuteScalar());

                decimal newAvgExact = ((newRating + (totalRatings * currAvg)) / (totalRatings + 1));
                int newAvg = (int)Math.Round(newAvgExact, 0);

                cmd.CommandText = "update movies set rating = " + newAvg + " where movieName = '" + movie + "';";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error 1 occured, unable to add rating to total average");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();
        }

        private void updateActorAvg(string movie, int rating)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
                string movieCast = "select A.actorID from actors A, movies_in MI, movies M where " +
                                   "A.actorID = MI.actorID and M.movieID = MI.movieID and " +
                                   "M.movieName = '" + movie + "'";

                // get number of times an actor has had a movie of theirs rated
                string temp = "select A.actorID as ID, ISNULL(count(*),0) as count from actors A, " + 
                              "orders O, movies_in MI where O.movieID = MI.movieID and A.actorID = MI.actorID " +
                              "and O.rating is not null group by A.actorID";


                // get actor ID, their rating, and the number of times their movie(s) has been rated
                string actorData = "select A.actorID, ISNULL(A.rating,0), temp.count from actors A, movies_in MI, " +
                                   "( " + temp + ") as temp where A.actorID = temp.ID and A.actorID in (" + movieCast + ");";

                SqlCommand cmd = new SqlCommand(actorData, myConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> updates = new List<string>();

                while (reader.Read())
                {
                    int actorID = Convert.ToInt32(reader.GetDecimal(0));
                    int currAvg = Convert.ToInt32(reader.GetDecimal(1));
                    int ratingCount = reader.GetInt32(2);
                    decimal newAvgExact = ((rating + (ratingCount * currAvg)) / (ratingCount + 1));
                    
                    int newAvg = (int)Math.Round(newAvgExact, 0);

                    MessageBox.Show("current movie count: " + ratingCount.ToString());
                    MessageBox.Show("decimal new average:" + newAvgExact.ToString() + "\nrounded avg: " + newAvg.ToString());

                    string updateStr = "update actors set rating = " + newAvg + " where actorID = " + actorID + ";";
                    updates.Add(updateStr);
                }
                reader.Close();
                foreach (string update in updates)
                {
                    cmd.CommandText = update;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occured, unable to add rating to total average");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();
        }
    }
}
