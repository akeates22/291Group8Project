using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace movieRentalApp
{
    public partial class updateRating : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand cmd;
        public string connectionString;
        public string CID;
        public updateRating(string connectionString, string CID)
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

                // get movies the customer has already rated
                string query = "select distinct M.movieName from movies M, orders O " + 
                               "where M.movieID = O.movieID and O.accountNum = " + this.CID + 
                               " and O.rating is not null;";

                SqlCommand cmd = new SqlCommand(query, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                da.Fill(dt);

                if (dt.Tables[0].Rows.Count > 0)
                {
                    this.movie.DataSource = dt.Tables[0];
                    this.movie.DisplayMember = "movieName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get movies, please try again later");
                MessageBox.Show(ex.Message);  
            }
            myConnection.Close();
        }

        private void postUpdatedRating(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                string selectedMovie = this.movie.GetItemText(this.movie.SelectedItem);
                int newRating = Int32.Parse(this.rating.Text);

                myConnection.Open();

                string subQuery = "select Top 1 O.orderID from Orders O, movies M " +
                                  "where O.movieID = M.movieID and O.accountNum = " + this.CID +
                                  " and M.movieName = '" + selectedMovie + "' order by dateTo asc";
                string updateCmd = "update orders set rating = " + newRating + " where accountNum = " + this.CID +
                                   " and orderID in (" + subQuery + ");";

                SqlCommand cmd = new SqlCommand(updateCmd, myConnection);
                cmd.ExecuteNonQuery();
                myConnection.Close();

                MessageBox.Show("Rating updated!");

                var ratingHandler = new Rate_Movie(connectionString, CID);
                ratingHandler.updateMovieAvg(selectedMovie, newRating);
                ratingHandler.updateActorAvg(selectedMovie, newRating);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to update ratings, please try again later");
                MessageBox.Show(ex.Message);
                myConnection.Close();
            }
            this.Close();
        }
    }
}
