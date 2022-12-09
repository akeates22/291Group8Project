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
            this.cancelChanges = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.postalCode = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.province = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.updateAccInfo = new System.Windows.Forms.Button();
            this.saveAccInfoChanges = new System.Windows.Forms.Button();
            this.rentalLimit = new System.Windows.Forms.TextBox();
            this.fees = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subPlan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ccNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelChanges
            // 
            this.cancelChanges.Location = new System.Drawing.Point(477, 431);
            this.cancelChanges.Name = "cancelChanges";
            this.cancelChanges.Size = new System.Drawing.Size(157, 43);
            this.cancelChanges.TabIndex = 73;
            this.cancelChanges.Text = "Cancel";
            this.cancelChanges.UseVisualStyleBackColor = true;
            this.cancelChanges.Visible = false;
            this.cancelChanges.Click += new System.EventHandler(this.cancelUpdates);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(217, 400);
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Size = new System.Drawing.Size(157, 27);
            this.phone.TabIndex = 72;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(217, 452);
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(157, 27);
            this.email.TabIndex = 71;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(30, 403);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 20);
            this.label21.TabIndex = 70;
            this.label21.Text = "Phone:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(30, 456);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 20);
            this.label20.TabIndex = 69;
            this.label20.Text = "Email:";
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(217, 347);
            this.postalCode.Name = "postalCode";
            this.postalCode.ReadOnly = true;
            this.postalCode.Size = new System.Drawing.Size(157, 27);
            this.postalCode.TabIndex = 68;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(30, 350);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 20);
            this.label19.TabIndex = 67;
            this.label19.Text = "Postal/zip Code:";
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(217, 242);
            this.province.Name = "province";
            this.province.ReadOnly = true;
            this.province.Size = new System.Drawing.Size(157, 27);
            this.province.TabIndex = 66;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(30, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 20);
            this.label16.TabIndex = 65;
            this.label16.Text = "Province/State:";
            // 
            // updateAccInfo
            // 
            this.updateAccInfo.Location = new System.Drawing.Point(477, 311);
            this.updateAccInfo.Name = "updateAccInfo";
            this.updateAccInfo.Size = new System.Drawing.Size(157, 43);
            this.updateAccInfo.TabIndex = 64;
            this.updateAccInfo.Text = "Update Information";
            this.updateAccInfo.UseVisualStyleBackColor = true;
            this.updateAccInfo.Click += new System.EventHandler(this.editInfo);
            // 
            // saveAccInfoChanges
            // 
            this.saveAccInfoChanges.Location = new System.Drawing.Point(477, 369);
            this.saveAccInfoChanges.Name = "saveAccInfoChanges";
            this.saveAccInfoChanges.Size = new System.Drawing.Size(157, 43);
            this.saveAccInfoChanges.TabIndex = 63;
            this.saveAccInfoChanges.Text = "Save Changes";
            this.saveAccInfoChanges.UseVisualStyleBackColor = true;
            this.saveAccInfoChanges.Visible = false;
            this.saveAccInfoChanges.Click += new System.EventHandler(this.saveAcctChanges);
            // 
            // rentalLimit
            // 
            this.rentalLimit.Location = new System.Drawing.Point(585, 241);
            this.rentalLimit.Name = "rentalLimit";
            this.rentalLimit.ReadOnly = true;
            this.rentalLimit.Size = new System.Drawing.Size(157, 27);
            this.rentalLimit.TabIndex = 62;
            // 
            // fees
            // 
            this.fees.Location = new System.Drawing.Point(585, 188);
            this.fees.Name = "fees";
            this.fees.ReadOnly = true;
            this.fees.Size = new System.Drawing.Size(157, 27);
            this.fees.TabIndex = 61;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(217, 188);
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Size = new System.Drawing.Size(157, 27);
            this.city.TabIndex = 59;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(217, 294);
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Size = new System.Drawing.Size(157, 27);
            this.address.TabIndex = 58;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(217, 135);
            this.lName.Name = "lName";
            this.lName.ReadOnly = true;
            this.lName.Size = new System.Drawing.Size(157, 27);
            this.lName.TabIndex = 57;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(217, 82);
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            this.fName.Size = new System.Drawing.Size(157, 27);
            this.fName.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 38);
            this.label1.TabIndex = 55;
            this.label1.Text = "Customer Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(406, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Rental Limit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(406, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Subscription Plan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(406, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "First Name:";
            // 
            // subPlan
            // 
            this.subPlan.BackColor = System.Drawing.SystemColors.Control;
            this.subPlan.Enabled = false;
            this.subPlan.FormattingEnabled = true;
            this.subPlan.Items.AddRange(new object[] {
            "Basic",
            "Premium",
            "Premium Plus"});
            this.subPlan.Location = new System.Drawing.Point(585, 135);
            this.subPlan.Name = "subPlan";
            this.subPlan.Size = new System.Drawing.Size(157, 28);
            this.subPlan.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(408, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "Credit Card No:";
            // 
            // ccNum
            // 
            this.ccNum.Location = new System.Drawing.Point(585, 81);
            this.ccNum.Name = "ccNum";
            this.ccNum.ReadOnly = true;
            this.ccNum.Size = new System.Drawing.Size(157, 27);
            this.ccNum.TabIndex = 76;
            // 
            // Employee_Customer_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(770, 516);
            this.Controls.Add(this.ccNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.subPlan);
            this.Controls.Add(this.cancelChanges);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.province);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.updateAccInfo);
            this.Controls.Add(this.saveAccInfoChanges);
            this.Controls.Add(this.rentalLimit);
            this.Controls.Add(this.fees);
            this.Controls.Add(this.city);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Employee_Customer_Search";
            this.Text = "Employee_Customer_Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelChanges;
        private TextBox phone;
        private TextBox email;
        private Label label21;
        private Label label20;
        private TextBox postalCode;
        private Label label19;
        private TextBox province;
        private Label label16;
        private Button updateAccInfo;
        private Button saveAccInfoChanges;
        private TextBox rentalLimit;
        private TextBox fees;
        private TextBox city;
        private TextBox address;
        private TextBox lName;
        private TextBox fName;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox subPlan;
        private Label label9;
        private TextBox ccNum;
    }
}