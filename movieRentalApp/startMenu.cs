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
            var signup = new signupForm();
            signup.Show();

        }

        private void loginClick(object sender, EventArgs e)
        {
            var login = new loginForm();
            login.Show();
        }

    }
}