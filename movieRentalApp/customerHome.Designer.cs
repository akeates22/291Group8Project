namespace movieRentalApp
{
    partial class customerHome
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
            this.custMovieSearch = new System.Windows.Forms.Button();
            this.custAccountInfo = new System.Windows.Forms.Button();
            this.currentRentals = new System.Windows.Forms.Button();
            this.rateMovie = new System.Windows.Forms.Button();
            this.custSuggestions = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custMovieSearch
            // 
            this.custMovieSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.custMovieSearch.Location = new System.Drawing.Point(36, 116);
            this.custMovieSearch.Name = "custMovieSearch";
            this.custMovieSearch.Size = new System.Drawing.Size(289, 55);
            this.custMovieSearch.TabIndex = 0;
            this.custMovieSearch.Text = "Find a Movie";
            this.custMovieSearch.UseVisualStyleBackColor = true;
            this.custMovieSearch.Click += new System.EventHandler(this.movieSearchClick);
            // 
            // custAccountInfo
            // 
            this.custAccountInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.custAccountInfo.Location = new System.Drawing.Point(476, 280);
            this.custAccountInfo.Name = "custAccountInfo";
            this.custAccountInfo.Size = new System.Drawing.Size(289, 55);
            this.custAccountInfo.TabIndex = 3;
            this.custAccountInfo.Text = "Account Information";
            this.custAccountInfo.UseVisualStyleBackColor = true;
            this.custAccountInfo.Click += new System.EventHandler(this.accountInfoClick);
            // 
            // currentRentals
            // 
            this.currentRentals.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.currentRentals.Location = new System.Drawing.Point(476, 115);
            this.currentRentals.Name = "currentRentals";
            this.currentRentals.Size = new System.Drawing.Size(289, 55);
            this.currentRentals.TabIndex = 4;
            this.currentRentals.Text = "Current Rentals";
            this.currentRentals.UseVisualStyleBackColor = true;
            this.currentRentals.Click += new System.EventHandler(this.currentRentalsClick);
            // 
            // rateMovie
            // 
            this.rateMovie.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.rateMovie.Location = new System.Drawing.Point(36, 280);
            this.rateMovie.Name = "rateMovie";
            this.rateMovie.Size = new System.Drawing.Size(289, 55);
            this.rateMovie.TabIndex = 5;
            this.rateMovie.Text = "Rate movies";
            this.rateMovie.UseVisualStyleBackColor = true;
            this.rateMovie.Click += new System.EventHandler(this.movieRatingsClick);
            // 
            // custSuggestions
            // 
            this.custSuggestions.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.custSuggestions.Location = new System.Drawing.Point(36, 198);
            this.custSuggestions.Name = "custSuggestions";
            this.custSuggestions.Size = new System.Drawing.Size(289, 55);
            this.custSuggestions.TabIndex = 6;
            this.custSuggestions.Text = "Suggested Movies";
            this.custSuggestions.UseVisualStyleBackColor = true;
            this.custSuggestions.Click += new System.EventHandler(this.custSuggestionsClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(476, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rental History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rentalHistoryClick);
            // 
            // customerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.custSuggestions);
            this.Controls.Add(this.rateMovie);
            this.Controls.Add(this.currentRentals);
            this.Controls.Add(this.custAccountInfo);
            this.Controls.Add(this.custMovieSearch);
            this.Name = "customerHome";
            this.Text = "customerHome";
            this.ResumeLayout(false);

        }

        #endregion

        private Button custMovieSearch;
        private Button custAccountInfo;
        private Button currentRentals;
        private Button rateMovie;
        private Button custSuggestions;
        private Button button1;
    }
}