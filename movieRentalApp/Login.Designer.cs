namespace movieRentalApp
{
    partial class Login
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
            this.loginHeader = new System.Windows.Forms.Label();
            this.custIDLoginLabel = new System.Windows.Forms.Label();
            this.fnameLoginLabel = new System.Windows.Forms.Label();
            this.lnameLoginLabel = new System.Windows.Forms.Label();
            this.loginFnameInput = new System.Windows.Forms.TextBox();
            this.IDinput = new System.Windows.Forms.TextBox();
            this.loginLnameInput = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginHeader
            // 
            this.loginHeader.AutoSize = true;
            this.loginHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginHeader.ForeColor = System.Drawing.Color.Yellow;
            this.loginHeader.Location = new System.Drawing.Point(112, 21);
            this.loginHeader.Name = "loginHeader";
            this.loginHeader.Size = new System.Drawing.Size(576, 54);
            this.loginHeader.TabIndex = 0;
            this.loginHeader.Text = "Blockbuster Video Rental Login";
            // 
            // custIDLoginLabel
            // 
            this.custIDLoginLabel.AutoSize = true;
            this.custIDLoginLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custIDLoginLabel.ForeColor = System.Drawing.Color.Yellow;
            this.custIDLoginLabel.Location = new System.Drawing.Point(142, 274);
            this.custIDLoginLabel.Name = "custIDLoginLabel";
            this.custIDLoginLabel.Size = new System.Drawing.Size(292, 31);
            this.custIDLoginLabel.TabIndex = 1;
            this.custIDLoginLabel.Text = "ID (Customer or Employee):";
            // 
            // fnameLoginLabel
            // 
            this.fnameLoginLabel.AutoSize = true;
            this.fnameLoginLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnameLoginLabel.ForeColor = System.Drawing.Color.Yellow;
            this.fnameLoginLabel.Location = new System.Drawing.Point(142, 146);
            this.fnameLoginLabel.Name = "fnameLoginLabel";
            this.fnameLoginLabel.Size = new System.Drawing.Size(135, 31);
            this.fnameLoginLabel.TabIndex = 2;
            this.fnameLoginLabel.Text = "First Name: ";
            // 
            // lnameLoginLabel
            // 
            this.lnameLoginLabel.AutoSize = true;
            this.lnameLoginLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnameLoginLabel.ForeColor = System.Drawing.Color.Yellow;
            this.lnameLoginLabel.Location = new System.Drawing.Point(142, 212);
            this.lnameLoginLabel.Name = "lnameLoginLabel";
            this.lnameLoginLabel.Size = new System.Drawing.Size(127, 31);
            this.lnameLoginLabel.TabIndex = 3;
            this.lnameLoginLabel.Text = "Last Name:";
            // 
            // loginFnameInput
            // 
            this.loginFnameInput.ForeColor = System.Drawing.Color.Black;
            this.loginFnameInput.Location = new System.Drawing.Point(440, 149);
            this.loginFnameInput.Name = "loginFnameInput";
            this.loginFnameInput.Size = new System.Drawing.Size(218, 27);
            this.loginFnameInput.TabIndex = 4;
            // 
            // IDinput
            // 
            this.IDinput.ForeColor = System.Drawing.Color.Black;
            this.IDinput.Location = new System.Drawing.Point(440, 275);
            this.IDinput.Name = "IDinput";
            this.IDinput.Size = new System.Drawing.Size(218, 27);
            this.IDinput.TabIndex = 5;
            // 
            // loginLnameInput
            // 
            this.loginLnameInput.ForeColor = System.Drawing.Color.Black;
            this.loginLnameInput.Location = new System.Drawing.Point(440, 213);
            this.loginLnameInput.Name = "loginLnameInput";
            this.loginLnameInput.Size = new System.Drawing.Size(218, 27);
            this.loginLnameInput.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(304, 358);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(193, 56);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.submitLoginForm);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginLnameInput);
            this.Controls.Add(this.IDinput);
            this.Controls.Add(this.loginFnameInput);
            this.Controls.Add(this.lnameLoginLabel);
            this.Controls.Add(this.fnameLoginLabel);
            this.Controls.Add(this.custIDLoginLabel);
            this.Controls.Add(this.loginHeader);
            this.Name = "Login";
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loginHeader;
        private Label custIDLoginLabel;
        private Label fnameLoginLabel;
        private Label lnameLoginLabel;
        private TextBox loginFnameInput;
        private TextBox IDinput;
        private TextBox loginLnameInput;
        private Button loginButton;
    }
}