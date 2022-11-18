using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieRentalApp
{
    public partial class Rate_Movie : Form
    {
        public Rate_Movie()
        {
            InitializeComponent();
        }

        private void Rate_Movie_Load(object sender, EventArgs e)
        {

        }

        private void postMovieRating(object sender, EventArgs e)
        {
            MessageBox.Show("Rating added");
            this.Close();
        }
    }
}
