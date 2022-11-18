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
    public partial class Rate_Actor : Form
    {
        public Rate_Actor()
        {
            InitializeComponent();
        }

        private void Rate_Actor_Load(object sender, EventArgs e)
        {

        }

        private void postActorRating(object sender, EventArgs e)
        {
            MessageBox.Show("Rating added");
            this.Close();
        }
    }
}
