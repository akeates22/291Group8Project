namespace movieRentalApp
{
    partial class loginForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginHeader
            // 
            this.loginHeader.AutoSize = true;
            this.loginHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginHeader.Location = new System.Drawing.Point(164, 21);
            this.loginHeader.Name = "loginHeader";
            this.loginHeader.Size = new System.Drawing.Size(420, 54);
            this.loginHeader.TabIndex = 0;
            this.loginHeader.Text = "___ Video Rental Login";
            // 
            // custIDLoginLabel
            // 
            this.custIDLoginLabel.AutoSize = true;
            this.custIDLoginLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custIDLoginLabel.Location = new System.Drawing.Point(153, 257);
            this.custIDLoginLabel.Name = "custIDLoginLabel";
            this.custIDLoginLabel.Size = new System.Drawing.Size(145, 31);
            this.custIDLoginLabel.TabIndex = 1;
            this.custIDLoginLabel.Text = "Customer ID:";
            // 
            // fnameLoginLabel
            // 
            this.fnameLoginLabel.AutoSize = true;
            this.fnameLoginLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnameLoginLabel.Location = new System.Drawing.Point(153, 129);
            this.fnameLoginLabel.Name = "fnameLoginLabel";
            this.fnameLoginLabel.Size = new System.Drawing.Size(135, 31);
            this.fnameLoginLabel.TabIndex = 2;
            this.fnameLoginLabel.Text = "First Name: ";
            // 
            // lnameLoginLabel
            // 
            this.lnameLoginLabel.AutoSize = true;
            this.lnameLoginLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnameLoginLabel.Location = new System.Drawing.Point(153, 193);
            this.lnameLoginLabel.Name = "lnameLoginLabel";
            this.lnameLoginLabel.Size = new System.Drawing.Size(127, 31);
            this.lnameLoginLabel.TabIndex = 3;
            this.lnameLoginLabel.Text = "Last Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 27);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(366, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 27);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(304, 358);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(193, 56);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.submitLoginForm);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lnameLoginLabel);
            this.Controls.Add(this.fnameLoginLabel);
            this.Controls.Add(this.custIDLoginLabel);
            this.Controls.Add(this.loginHeader);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loginHeader;
        private Label custIDLoginLabel;
        private Label fnameLoginLabel;
        private Label lnameLoginLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button loginButton;
    }
}