using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace movieRentalApp
{
    public partial class startMenu : Form
    {
        public SqlConnection dbConnection;
        public SqlCommand dbCommand;
        public SqlDataReader dbReader;

        public startMenu()
        {
            InitializeComponent();

            string connectionString = "Server = ANDREWS-PC; Database = 291Project; Trusted_Connection = yes";

            SqlConnection dbConnection = new SqlConnection(connectionString);

            try
            {
                dbConnection.Open();
                dbCommand = new SqlCommand();
                dbCommand.Connection = dbConnection;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
        }   

        private void signupClick(object sender, EventArgs e)
        {
            var signup = new Signup();
            signup.Show();

        }

        private void loginClick(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Close();
        }

    }
}