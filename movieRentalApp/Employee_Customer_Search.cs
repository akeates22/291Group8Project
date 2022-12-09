using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace movieRentalApp
{
    public partial class Employee_Customer_Search : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand cmd;
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
                           "[zip/postalCode], phone, email, creditCardNum, subType from customers C " +
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
                ccNum.Text = dr.GetString(8);
                subPlan.SelectedIndex = subPlan.FindStringExact(dr.GetString(9));

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
            ccNum.ReadOnly = false;

            saveAccInfoChanges.Visible = true;
            cancelChanges.Visible = true;
        }

        private void cancelUpdates(object sender, EventArgs e)
        {
            this.getResults();

            fName.ReadOnly = true;
            lName.ReadOnly = true;
            address.ReadOnly = true;
            city.ReadOnly = true;
            province.ReadOnly = true;
            postalCode.ReadOnly = true;
            phone.ReadOnly = true;
            email.ReadOnly = true;
            ccNum.ReadOnly = true;

            saveAccInfoChanges.Visible = false;
            cancelChanges.Visible = false;
        }

        private void saveAcctChanges(object sender, EventArgs e)
        {
            string fName  = this.fName.Text;
            string lName  = this.lName.Text;
            string city   = this.city.Text;
            string prov   = this.province.Text;
            string addr   = this.address.Text;
            string postal = this.postalCode.Text;
            string phone  = this.phone.Text;
            string email  = this.email.Text;
            string ccNum = this.ccNum.Text;

            string subPlan = this.subPlan.GetItemText(this.subPlan.SelectedItem);

            // phone must be a number
            if (!phone.All(char.IsDigit)) { MessageBox.Show("Invalid phone number"); return; }
            if (!ccNum.All(char.IsDigit)) { MessageBox.Show("Invalid credit card number"); return; }

            // make sure no inputs are blank
            string[] inputs = { fName, lName, city, prov, addr, postal, email };
            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Invalid entries, fields cannot be empty");
                    return;
                }
            }

            string update = "update customers set firstName = '" + fName + "', lastName = '" + lName +
                            "', address = '" + addr + "', city = '" + city + "', [state/province] = '" +
                            prov + "', [zip/postalCode] = '" + postal + "', phone = '" + phone + "', " +
                            "email = '" + email + "', creditCardNum = '" + ccNum + "', subType = '" + subPlan +
                            "' where accountNum = " + this.CID + ";";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                SqlCommand cmd = new SqlCommand(update, myConnection);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save account updates, please try again later");
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();

            this.fName.ReadOnly = true;
            this.lName.ReadOnly = true;
            this.address.ReadOnly = true;
            this.city.ReadOnly = true;
            this.province.ReadOnly = true;
            this.postalCode.ReadOnly = true;
            this.phone.ReadOnly = true;
            this.email.ReadOnly = true;
            this.ccNum.ReadOnly = true;

            saveAccInfoChanges.Visible = false;
            cancelChanges.Visible = false;
        }

    }
}
