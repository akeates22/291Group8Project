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
    public partial class customerAccInfo : Form
    {
        public customerAccInfo()
        {
            InitializeComponent();

            // create function to display user's info, ideally without any noticeable delay/change
            // either check database, or get parameters from customerHome (probably better)
            // ref: https://stackoverflow.com/questions/48778018/c-update-label-text-on-windows-forms-from-console-application
        }
    }
}
