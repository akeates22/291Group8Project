namespace movieRentalApp
{
    partial class Customer_Search_Results
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Movie 1",
            "3 DVD, 1 VHS",
            "4/10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Movie 2",
            "2 DVD, 4 VHS",
            "6/10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Movie 3",
            "1 DVD",
            "5/10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Movie 4",
            "2 DVD, 5 VHS",
            "9/10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Movie 4",
            "7 VHS",
            "8/10"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.movieTitle = new System.Windows.Forms.ColumnHeader();
            this.copyType = new System.Windows.Forms.ColumnHeader();
            this.mRating = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.AliceBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.movieTitle,
            this.copyType,
            this.mRating});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(557, 386);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // movieTitle
            // 
            this.movieTitle.Text = "Movie Title";
            this.movieTitle.Width = 290;
            // 
            // copyType
            // 
            this.copyType.Text = "Copies";
            this.copyType.Width = 165;
            // 
            // mRating
            // 
            this.mRating.Text = "Rating";
            this.mRating.Width = 100;
            // 
            // Customer_Search_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(557, 386);
            this.Controls.Add(this.listView1);
            this.Name = "Customer_Search_Results";
            this.Text = "Customer_Search_Results";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader movieTitle;
        private ColumnHeader copyType;
        private ColumnHeader mRating;
    }
}