using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieRentalApp
{
    public partial class Employee_Customer_Search : Form
    {
        public string connectionString;
        public string CID;

        public Employee_Customer_Search(string connectionString, string CID)
        {
            this.connectionString = connectionString;
            this.CID = CID;
            InitializeComponent();
        }

        public void getResults()
        {
            string query = "select firstName, lastName, city, [state/province], [address], " +
                           "[zip/postalCode], phone, email, subType from customers C " +
                           "where C.accountNum = " + CID + ";";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                SqlCommand cmd = new SqlCommand(query, myConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    MessageBox.Show("Customer not found, please check your inputs and try again");
                    myConnection.Close();
                    this.Close();
                    return;
                }
                fName.Text = dr.GetString(0);
                lName.Text = dr.GetString(1);
                city.Text = dr.GetString(2);
                province.Text = dr.GetString(3);
                address.Text = dr.GetString(4);
                postalCode.Text = dr.GetString(5);
                phone.Text = dr.GetString(6);
                email.Text = dr.GetString(7);
                subPlan.SelectedIndex = subPlan.FindStringExact(dr.GetString(8));

                //subPlan.Text = dr.GetString(8);

                switch (subPlan.Text)
                {
                    case "Basic":
                        fees.Text = "$5 / month";
                        rentalLimit.Text = "8 / month";
                        break;
                    case "Premium":
                        fees.Text = "$10 / month";
                        rentalLimit.Text = "12 / month";
                        break;
                    case "Premium Plus":
                        fees.Text = "$15 / month";
                        rentalLimit.Text = "20 / month";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get customer information, please try again later");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();
        }

        private void editInfo(object sender, EventArgs e)
        {
            fName.ReadOnly = false;
            lName.ReadOnly = false;
            address.ReadOnly = false;
            city.ReadOnly = false;
            province.ReadOnly = false;
            postalCode.ReadOnly = false;
            phone.ReadOnly = false;
            email.ReadOnly = false;

            saveAccInfoChanges.Visible = true;
            cancelChanges.Visible = true;
        }
    }
}
