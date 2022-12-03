namespace movieRentalApp
{
    public partial class startMenu : Form
    {
        public string connectionString;
        public startMenu()
        {
            this.connectionString = "Server = ANDREWS-PC; Database = 291Project; Trusted_Connection = Yes";
            InitializeComponent();
        }   

        private void signupClick(object sender, EventArgs e)
        {
            var signup = new Signup(connectionString);
            signup.Show();

        }

        private void loginClick(object sender, EventArgs e)
        {
            var login = new Login(connectionString);
            login.Show();
            this.Close();
        }

    }
}