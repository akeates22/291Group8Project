﻿using System;
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
    public partial class Customer_Home2 : Form
    {
        public Customer_Home2()
        {
            InitializeComponent();
        }

        private void custMovieSearch(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(0);
        }

        private void showCurrentRentals(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(1);
        }

        private void showRentalHistory(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(2);
        }

        private void showCustRatings(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(3);
        }
        private void showAccInfo(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(4);
        }

        private void orderMenu(object sender, EventArgs e)
        {
            this.contentBox.SelectTab(5);
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void getMovieResults(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}