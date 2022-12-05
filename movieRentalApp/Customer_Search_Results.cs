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
    public partial class Customer_Search_Results : Form
    {
        public string[] results;
        public Customer_Search_Results(string[] results)
        {
            this.results = results; 
            InitializeComponent();
        }

        public void DisplayResults()
        {
            ListView table = new ListView();
            table.View = View.Details;
            table.Dock = DockStyle.Fill;
            table.Columns.Add("Movie Title", 250);
            table.Columns.Add("Format", 125);
            table.Columns.Add("Count", 80);

            foreach(var result in results)
            {
                string[] values = result.Split("   ");
                ListViewItem row = new ListViewItem(values);
                table.Items.Add(row);
            }
            Controls.Add(table);
        }
    }
}
