namespace movieRentalApp
{
    partial class Employee_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rentalApprovalButton = new System.Windows.Forms.RadioButton();
            this.employeeMovieSearch = new System.Windows.Forms.RadioButton();
            this.customerSearchButton = new System.Windows.Forms.RadioButton();
            this.empInfoButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contentBox = new System.Windows.Forms.TabControl();
            this.movieSearch = new System.Windows.Forms.TabPage();
            this.empSearchButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.employeeInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rentalLimitLabel = new System.Windows.Forms.Label();
            this.mailingAddress = new System.Windows.Forms.Label();
            this.feesLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contentBox.SuspendLayout();
            this.movieSearch.SuspendLayout();
            this.employeeInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rentalApprovalButton);
            this.panel1.Controls.Add(this.employeeMovieSearch);
            this.panel1.Controls.Add(this.customerSearchButton);
            this.panel1.Controls.Add(this.empInfoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 1080);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 300);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // rentalApprovalButton
            // 
            this.rentalApprovalButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rentalApprovalButton.BackColor = System.Drawing.Color.AliceBlue;
            this.rentalApprovalButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.rentalApprovalButton.FlatAppearance.BorderSize = 2;
            this.rentalApprovalButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.rentalApprovalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalApprovalButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentalApprovalButton.Location = new System.Drawing.Point(8, 413);
            this.rentalApprovalButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rentalApprovalButton.Name = "rentalApprovalButton";
            this.rentalApprovalButton.Size = new System.Drawing.Size(472, 108);
            this.rentalApprovalButton.TabIndex = 3;
            this.rentalApprovalButton.Text = "Approve Rentals";
            this.rentalApprovalButton.UseVisualStyleBackColor = false;
            this.rentalApprovalButton.Click += new System.EventHandler(this.showApproveRentals);
            // 
            // employeeMovieSearch
            // 
            this.employeeMovieSearch.Appearance = System.Windows.Forms.Appearance.Button;
            this.employeeMovieSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.employeeMovieSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.employeeMovieSearch.FlatAppearance.BorderSize = 2;
            this.employeeMovieSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.employeeMovieSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeMovieSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeMovieSearch.Location = new System.Drawing.Point(8, 559);
            this.employeeMovieSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.employeeMovieSearch.Name = "employeeMovieSearch";
            this.employeeMovieSearch.Size = new System.Drawing.Size(472, 108);
            this.employeeMovieSearch.TabIndex = 2;
            this.employeeMovieSearch.Text = "Movie Search";
            this.employeeMovieSearch.UseVisualStyleBackColor = false;
            this.employeeMovieSearch.CheckedChanged += new System.EventHandler(this.employeeMovieSearch_CheckedChanged);
            this.employeeMovieSearch.Click += new System.EventHandler(this.showEmpMovieSearch);
            // 
            // customerSearchButton
            // 
            this.customerSearchButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.customerSearchButton.BackColor = System.Drawing.Color.AliceBlue;
            this.customerSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.customerSearchButton.FlatAppearance.BorderSize = 2;
            this.customerSearchButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.customerSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerSearchButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerSearchButton.Location = new System.Drawing.Point(8, 706);
            this.customerSearchButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.customerSearchButton.Name = "customerSearchButton";
            this.customerSearchButton.Size = new System.Drawing.Size(472, 108);
            this.customerSearchButton.TabIndex = 3;
            this.customerSearchButton.Text = "Customer Search";
            this.customerSearchButton.UseVisualStyleBackColor = false;
            this.customerSearchButton.CheckedChanged += new System.EventHandler(this.customerSearchButton_CheckedChanged);
            this.customerSearchButton.Click += new System.EventHandler(this.showEmpCustSearch);
            // 
            // empInfoButton
            // 
            this.empInfoButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.empInfoButton.BackColor = System.Drawing.Color.AliceBlue;
            this.empInfoButton.Checked = true;
            this.empInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.empInfoButton.FlatAppearance.BorderSize = 2;
            this.empInfoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.empInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empInfoButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empInfoButton.Location = new System.Drawing.Point(8, 852);
            this.empInfoButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.empInfoButton.Name = "empInfoButton";
            this.empInfoButton.Size = new System.Drawing.Size(472, 108);
            this.empInfoButton.TabIndex = 1;
            this.empInfoButton.TabStop = true;
            this.empInfoButton.Text = "Account Information";
            this.empInfoButton.UseVisualStyleBackColor = false;
            this.empInfoButton.Click += new System.EventHandler(this.showEmpInfo);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contentBox);
            this.panel2.Location = new System.Drawing.Point(645, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 1075);
            this.panel2.TabIndex = 4;
            // 
            // contentBox
            // 
            this.contentBox.Controls.Add(this.movieSearch);
            this.contentBox.Controls.Add(this.employeeInfo);
            this.contentBox.Controls.Add(this.tabPage2);
            this.contentBox.Controls.Add(this.tabPage1);
            this.contentBox.Location = new System.Drawing.Point(8, 29);
            this.contentBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.contentBox.Name = "contentBox";
            this.contentBox.SelectedIndex = 0;
            this.contentBox.Size = new System.Drawing.Size(1222, 1039);
            this.contentBox.TabIndex = 0;
            // 
            // movieSearch
            // 
            this.movieSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.movieSearch.Controls.Add(this.empSearchButton);
            this.movieSearch.Controls.Add(this.comboBox1);
            this.movieSearch.Controls.Add(this.label11);
            this.movieSearch.Controls.Add(this.label9);
            this.movieSearch.Controls.Add(this.label10);
            this.movieSearch.Controls.Add(this.searchLabel);
            this.movieSearch.Controls.Add(this.textBox3);
            this.movieSearch.Controls.Add(this.textBox1);
            this.movieSearch.Location = new System.Drawing.Point(12, 69);
            this.movieSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.movieSearch.Name = "movieSearch";
            this.movieSearch.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.movieSearch.Size = new System.Drawing.Size(1198, 958);
            this.movieSearch.TabIndex = 0;
            this.movieSearch.Text = "movie search";
            // 
            // empSearchButton
            // 
            this.empSearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.empSearchButton.Location = new System.Drawing.Point(390, 766);
            this.empSearchButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.empSearchButton.Name = "empSearchButton";
            this.empSearchButton.Size = new System.Drawing.Size(420, 108);
            this.empSearchButton.TabIndex = 11;
            this.empSearchButton.Text = "Get Results";
            this.empSearchButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Romance",
            "Sci-fi",
            "Thriller"});
            this.comboBox1.Location = new System.Drawing.Point(642, 617);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 56);
            this.comboBox1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(190, 626);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 60);
            this.label11.TabIndex = 9;
            this.label11.Text = "Genre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(190, 456);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 60);
            this.label9.TabIndex = 8;
            this.label9.Text = "Starring:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(190, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 60);
            this.label10.TabIndex = 7;
            this.label10.Text = "Title:";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(410, 96);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(385, 74);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Movie Search";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(642, 444);
            this.textBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(306, 55);
            this.textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 278);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 55);
            this.textBox1.TabIndex = 0;
            // 
            // employeeInfo
            // 
            this.employeeInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.employeeInfo.Controls.Add(this.label1);
            this.employeeInfo.Controls.Add(this.cityLabel);
            this.employeeInfo.Controls.Add(this.label8);
            this.employeeInfo.Controls.Add(this.rentalLimitLabel);
            this.employeeInfo.Controls.Add(this.mailingAddress);
            this.employeeInfo.Controls.Add(this.feesLabel);
            this.employeeInfo.Controls.Add(this.lnameLabel);
            this.employeeInfo.Controls.Add(this.subLabel);
            this.employeeInfo.Controls.Add(this.fnameLabel);
            this.employeeInfo.Controls.Add(this.label7);
            this.employeeInfo.Controls.Add(this.label6);
            this.employeeInfo.Controls.Add(this.label5);
            this.employeeInfo.Controls.Add(this.label4);
            this.employeeInfo.Controls.Add(this.label3);
            this.employeeInfo.Controls.Add(this.label2);
            this.employeeInfo.Location = new System.Drawing.Point(12, 69);
            this.employeeInfo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.employeeInfo.Size = new System.Drawing.Size(1198, 958);
            this.employeeInfo.TabIndex = 4;
            this.employeeInfo.Text = "acc info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 87);
            this.label1.TabIndex = 29;
            this.label1.Text = "Employee Information";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(708, 470);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(283, 47);
            this.cityLabel.TabIndex = 28;
            this.cityLabel.Text = "Edmonton, AB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(238, 470);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 47);
            this.label8.TabIndex = 27;
            this.label8.Text = "City:";
            // 
            // rentalLimitLabel
            // 
            this.rentalLimitLabel.AutoSize = true;
            this.rentalLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentalLimitLabel.Location = new System.Drawing.Point(708, 758);
            this.rentalLimitLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.rentalLimitLabel.Name = "rentalLimitLabel";
            this.rentalLimitLabel.Size = new System.Drawing.Size(233, 47);
            this.rentalLimitLabel.TabIndex = 26;
            this.rentalLimitLabel.Text = "Sales Clerk";
            // 
            // mailingAddress
            // 
            this.mailingAddress.AutoSize = true;
            this.mailingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mailingAddress.Location = new System.Drawing.Point(708, 374);
            this.mailingAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.mailingAddress.Name = "mailingAddress";
            this.mailingAddress.Size = new System.Drawing.Size(250, 47);
            this.mailingAddress.TabIndex = 25;
            this.mailingAddress.Text = "456 Main St.";
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feesLabel.Location = new System.Drawing.Point(708, 662);
            this.feesLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(205, 47);
            this.feesLabel.TabIndex = 24;
            this.feesLabel.Text = "$15 / hour";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnameLabel.Location = new System.Drawing.Point(708, 278);
            this.lnameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(204, 47);
            this.lnameLabel.TabIndex = 23;
            this.lnameLabel.Text = "Employee";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subLabel.Location = new System.Drawing.Point(708, 566);
            this.subLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(180, 47);
            this.subLabel.TabIndex = 22;
            this.subLabel.Text = "10/14/17";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnameLabel.Location = new System.Drawing.Point(708, 182);
            this.fnameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(204, 47);
            this.fnameLabel.TabIndex = 21;
            this.fnameLabel.Text = "Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(238, 758);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 47);
            this.label7.TabIndex = 20;
            this.label7.Text = "Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(238, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 47);
            this.label6.TabIndex = 19;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(238, 566);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 47);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hired Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(238, 662);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 47);
            this.label4.TabIndex = 17;
            this.label4.Text = "Wage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(238, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 47);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(238, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 47);
            this.label2.TabIndex = 15;
            this.label2.Text = "First Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Location = new System.Drawing.Point(12, 69);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Size = new System.Drawing.Size(1198, 958);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "cust Search";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(258, 451);
            this.label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 48);
            this.label16.TabIndex = 12;
            this.label16.Text = "(required)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(405, 749);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(420, 108);
            this.button1.TabIndex = 11;
            this.button1.Text = "Get Results";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(208, 511);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 60);
            this.label13.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(208, 401);
            this.label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(294, 60);
            this.label14.TabIndex = 7;
            this.label14.Text = "Customer ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(340, 84);
            this.label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(474, 74);
            this.label15.TabIndex = 6;
            this.label15.Text = "Customer Search";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(685, 398);
            this.textBox4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(306, 55);
            this.textBox4.TabIndex = 0;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(12, 69);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Size = new System.Drawing.Size(1198, 958);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "rentalApproval";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(340, 742);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(542, 120);
            this.button2.TabIndex = 5;
            this.button2.Text = "Submit Approvals";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.approveRentals);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(662, 190);
            this.label18.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(308, 65);
            this.label18.TabIndex = 4;
            this.label18.Text = "Customer ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(58, 190);
            this.label17.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(283, 65);
            this.label17.TabIndex = 3;
            this.label17.Text = "Movie Title";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Movie 1                                                      12345",
            "Movie 2                                                      12345",
            "Movie 3                                                      12345",
            "Movie 2                                                      12456",
            "Movie 1                                                      12456",
            "Movie 3                                                      12456",
            "Movie 1                                                      19862"});
            this.checkedListBox1.Location = new System.Drawing.Point(8, 264);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(1166, 328);
            this.checkedListBox1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(250, 67);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(691, 74);
            this.label12.TabIndex = 1;
            this.label12.Text = "Approve Rental Requests";
            // 
            // Employee_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Employee_Home";
            this.Text = "Employee_Home";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.contentBox.ResumeLayout(false);
            this.movieSearch.ResumeLayout(false);
            this.movieSearch.PerformLayout();
            this.employeeInfo.ResumeLayout(false);
            this.employeeInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        public PictureBox pictureBox1;
        public RadioButton rentalApprovalButton;
        public RadioButton employeeMovieSearch;
        public RadioButton customerSearchButton;
        public RadioButton empInfoButton;
        private Panel panel2;
        private TabControl contentBox;
        private TabPage movieSearch;
        private Button empSearchButton;
        private ComboBox comboBox1;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label searchLabel;
        private TextBox textBox3;
        private TextBox textBox1;
        private TabPage employeeInfo;
        private Label label1;
        private Label cityLabel;
        private Label label8;
        private Label rentalLimitLabel;
        private Label mailingAddress;
        private Label feesLabel;
        private Label lnameLabel;
        private Label subLabel;
        private Label fnameLabel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private Label label16;
        private Button button1;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox4;
        private TabPage tabPage1;
        private Label label12;
        private Button button2;
        private Label label18;
        private Label label17;
        private CheckedListBox checkedListBox1;
    }
}