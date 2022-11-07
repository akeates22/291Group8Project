﻿namespace movieRentalApp
{
    partial class signupForm
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
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.postalLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.ccLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.fnameInput = new System.Windows.Forms.TextBox();
            this.lnameInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.postalCodeInput = new System.Windows.Forms.TextBox();
            this.ccNumberInput = new System.Windows.Forms.TextBox();
            this.provinceInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.signupSubmit = new System.Windows.Forms.Button();
            this.premSubButton = new System.Windows.Forms.RadioButton();
            this.premPlusSubButton = new System.Windows.Forms.RadioButton();
            this.basicSubButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnameLabel.Location = new System.Drawing.Point(23, 26);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(129, 31);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First Name:";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnameLabel.Location = new System.Drawing.Point(378, 26);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(127, 31);
            this.lnameLabel.TabIndex = 1;
            this.lnameLabel.Text = "Last Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(23, 98);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(102, 31);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            // 
            // postalLabel
            // 
            this.postalLabel.AutoSize = true;
            this.postalLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalLabel.Location = new System.Drawing.Point(378, 98);
            this.postalLabel.Name = "postalLabel";
            this.postalLabel.Size = new System.Drawing.Size(139, 31);
            this.postalLabel.TabIndex = 3;
            this.postalLabel.Text = "Postal Code:";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.provinceLabel.Location = new System.Drawing.Point(378, 171);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(106, 31);
            this.provinceLabel.TabIndex = 4;
            this.provinceLabel.Text = "Province:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(23, 171);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(58, 31);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City:";
            // 
            // ccLabel
            // 
            this.ccLabel.AutoSize = true;
            this.ccLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ccLabel.Location = new System.Drawing.Point(23, 252);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(225, 31);
            this.ccLabel.TabIndex = 6;
            this.ccLabel.Text = "Credit Card Number:";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subLabel.Location = new System.Drawing.Point(23, 324);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(197, 31);
            this.subLabel.TabIndex = 7;
            this.subLabel.Text = "Subscription Plan:";
            // 
            // fnameInput
            // 
            this.fnameInput.Location = new System.Drawing.Point(158, 32);
            this.fnameInput.Name = "fnameInput";
            this.fnameInput.Size = new System.Drawing.Size(125, 27);
            this.fnameInput.TabIndex = 8;
            this.fnameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lnameInput
            // 
            this.lnameInput.Location = new System.Drawing.Point(523, 32);
            this.lnameInput.Name = "lnameInput";
            this.lnameInput.Size = new System.Drawing.Size(125, 27);
            this.lnameInput.TabIndex = 9;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(158, 104);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(125, 27);
            this.addressInput.TabIndex = 10;
            // 
            // postalCodeInput
            // 
            this.postalCodeInput.Location = new System.Drawing.Point(523, 104);
            this.postalCodeInput.Name = "postalCodeInput";
            this.postalCodeInput.Size = new System.Drawing.Size(125, 27);
            this.postalCodeInput.TabIndex = 11;
            this.postalCodeInput.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ccNumberInput
            // 
            this.ccNumberInput.Location = new System.Drawing.Point(254, 258);
            this.ccNumberInput.Name = "ccNumberInput";
            this.ccNumberInput.Size = new System.Drawing.Size(251, 27);
            this.ccNumberInput.TabIndex = 12;
            // 
            // provinceInput
            // 
            this.provinceInput.Location = new System.Drawing.Point(523, 177);
            this.provinceInput.Name = "provinceInput";
            this.provinceInput.Size = new System.Drawing.Size(125, 27);
            this.provinceInput.TabIndex = 13;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(158, 175);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(125, 27);
            this.cityInput.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // signupSubmit
            // 
            this.signupSubmit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signupSubmit.Location = new System.Drawing.Point(254, 453);
            this.signupSubmit.Name = "signupSubmit";
            this.signupSubmit.Size = new System.Drawing.Size(193, 56);
            this.signupSubmit.TabIndex = 17;
            this.signupSubmit.Text = "Submit";
            this.signupSubmit.UseVisualStyleBackColor = true;
            this.signupSubmit.Click += new System.EventHandler(this.submitSignupForm);
            // 
            // premSubButton
            // 
            this.premSubButton.AutoSize = true;
            this.premSubButton.Location = new System.Drawing.Point(254, 361);
            this.premSubButton.Name = "premSubButton";
            this.premSubButton.Size = new System.Drawing.Size(391, 24);
            this.premSubButton.TabIndex = 18;
            this.premSubButton.TabStop = true;
            this.premSubButton.Text = "Premium - cost: $10/month, limit 12 movies per month";
            this.premSubButton.UseVisualStyleBackColor = true;
            // 
            // premPlusSubButton
            // 
            this.premPlusSubButton.AutoSize = true;
            this.premPlusSubButton.Location = new System.Drawing.Point(254, 391);
            this.premPlusSubButton.Name = "premPlusSubButton";
            this.premPlusSubButton.Size = new System.Drawing.Size(397, 24);
            this.premPlusSubButton.TabIndex = 19;
            this.premPlusSubButton.TabStop = true;
            this.premPlusSubButton.Text = "Premium Plus - cost: $15/month, limit 20 movies/month";
            this.premPlusSubButton.UseVisualStyleBackColor = true;
            // 
            // basicSubButton
            // 
            this.basicSubButton.AutoSize = true;
            this.basicSubButton.Location = new System.Drawing.Point(254, 331);
            this.basicSubButton.Name = "basicSubButton";
            this.basicSubButton.Size = new System.Drawing.Size(350, 24);
            this.basicSubButton.TabIndex = 20;
            this.basicSubButton.TabStop = true;
            this.basicSubButton.Text = "Basic - cost: $5/month, limit 8 movies per month\r\n";
            this.basicSubButton.UseVisualStyleBackColor = true;
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.basicSubButton);
            this.Controls.Add(this.premPlusSubButton);
            this.Controls.Add(this.premSubButton);
            this.Controls.Add(this.signupSubmit);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.provinceInput);
            this.Controls.Add(this.ccNumberInput);
            this.Controls.Add(this.postalCodeInput);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.lnameInput);
            this.Controls.Add(this.fnameInput);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.ccLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.provinceLabel);
            this.Controls.Add(this.postalLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Name = "signupForm";
            this.Text = "signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fnameLabel;
        private Label lnameLabel;
        private Label addressLabel;
        private Label postalLabel;
        private Label provinceLabel;
        private Label cityLabel;
        private Label ccLabel;
        private Label subLabel;
        private TextBox fnameInput;
        private TextBox lnameInput;
        private TextBox addressInput;
        private TextBox postalCodeInput;
        private TextBox ccNumberInput;
        private TextBox provinceInput;
        private TextBox cityInput;
        private ToolStrip toolStrip1;
        private Button signupSubmit;
        private RadioButton premSubButton;
        private RadioButton premPlusSubButton;
        private RadioButton basicSubButton;
    }
}