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

                MessageBox.Show("Rating added!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add rating, please try again later");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();

            this.Close();
        }
    }
}
