namespace movieRentalApp
{
    partial class Employee_Customer_Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.phone = new System.Windows.Forms.ColumnHeader();
            this.email = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.subType = new System.Windows.Forms.ColumnHeader();
            this.ccNum = new System.Windows.Forms.ColumnHeader();
            this.custRating = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.phone,
            this.email,
            this.columnHeader3,
            this.columnHeader4,
            this.address,
            this.subType,
            this.ccNum,
            this.custRating});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(475, 413);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // phone
            // 
            this.phone.Text = "Phone Number";
            // 
            // email
            // 
            this.email.Text = "Email Address";
            // 
            // address
            // 
            this.address.Text = "Mailing Address";
            // 
            // subType
            // 
            this.subType.Text = "Subscription";
            // 
            // ccNum
            // 
            this.ccNum.Text = "Credit Card Number";
            // 
            // custRating
            // 
            this.custRating.Text = "Customer Rating";
            // 
            // Employee_Customer_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 413);
            this.Controls.Add(this.listView1);
            this.Name = "Employee_Customer_Search";
            this.Text = "Employee_Customer_Search";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader name;
        private ColumnHeader phone;
        private ColumnHeader email;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader address;
        private ColumnHeader subType;
        private ColumnHeader ccNum;
        private ColumnHeader custRating;
    }
}