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

        public void addMovies()
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
                // movies that customer has already rated
                string subQuery = "select distinct movieID from orders where " +
                                  "accountNum = " + this.CID + " and rating is not null";

                string query = "select distinct M.movieName from movies M, orders O, copies C " +
                               "where M.movieID = O.movieID and C.copyID = O.copyID and " +
                               "C.available = 'yes' and O.accountNum = " + this.CID + " and " +
                               "M.movieID not in ( " + subQuery + " );";

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
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();
            

        }
        private void postMovieRating(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {

            }
            myConnection.Close();
            MessageBox.Show("Rating added");
            this.Close();
        }
    }
}
