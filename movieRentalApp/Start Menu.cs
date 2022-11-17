namespace movieRentalApp
{
    public partial class startMenu : Form
    {
        public startMenu()
        {
            InitializeComponent();
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