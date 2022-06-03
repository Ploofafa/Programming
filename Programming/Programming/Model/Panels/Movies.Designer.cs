namespace Programming.Model.Panels
{
    partial class Movies
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesFindButton = new System.Windows.Forms.Button();
            this.MoviesYearTextBox = new System.Windows.Forms.TextBox();
            this.MoviesYearLabel = new System.Windows.Forms.Label();
            this.MoviesTitleTextBox = new System.Windows.Forms.TextBox();
            this.MoviesTitleLabel = new System.Windows.Forms.Label();
            this.MoviesRatingTextBox = new System.Windows.Forms.TextBox();
            this.MoviesRatingLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MoviesFindButton
            // 
            this.MoviesFindButton.Location = new System.Drawing.Point(136, 257);
            this.MoviesFindButton.Name = "MoviesFindButton";
            this.MoviesFindButton.Size = new System.Drawing.Size(100, 23);
            this.MoviesFindButton.TabIndex = 16;
            this.MoviesFindButton.Text = "Find";
            this.MoviesFindButton.UseVisualStyleBackColor = true;
            this.MoviesFindButton.Click += new System.EventHandler(this.MoviesFindButton_Click);
            // 
            // MoviesYearTextBox
            // 
            this.MoviesYearTextBox.Location = new System.Drawing.Point(136, 58);
            this.MoviesYearTextBox.Name = "MoviesYearTextBox";
            this.MoviesYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesYearTextBox.TabIndex = 15;
            this.MoviesYearTextBox.TextChanged += new System.EventHandler(this.MoviesYearTextBox_TextChanged);
            // 
            // MoviesYearLabel
            // 
            this.MoviesYearLabel.AutoSize = true;
            this.MoviesYearLabel.Location = new System.Drawing.Point(133, 42);
            this.MoviesYearLabel.Name = "MoviesYearLabel";
            this.MoviesYearLabel.Size = new System.Drawing.Size(32, 13);
            this.MoviesYearLabel.TabIndex = 14;
            this.MoviesYearLabel.Text = "Year:";
            // 
            // MoviesTitleTextBox
            // 
            this.MoviesTitleTextBox.Location = new System.Drawing.Point(136, 19);
            this.MoviesTitleTextBox.Name = "MoviesTitleTextBox";
            this.MoviesTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesTitleTextBox.TabIndex = 13;
            // 
            // MoviesTitleLabel
            // 
            this.MoviesTitleLabel.AutoSize = true;
            this.MoviesTitleLabel.Location = new System.Drawing.Point(133, 3);
            this.MoviesTitleLabel.Name = "MoviesTitleLabel";
            this.MoviesTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.MoviesTitleLabel.TabIndex = 12;
            this.MoviesTitleLabel.Text = "Title:";
            // 
            // MoviesRatingTextBox
            // 
            this.MoviesRatingTextBox.Location = new System.Drawing.Point(136, 97);
            this.MoviesRatingTextBox.Name = "MoviesRatingTextBox";
            this.MoviesRatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesRatingTextBox.TabIndex = 11;
            this.MoviesRatingTextBox.TextChanged += new System.EventHandler(this.MoviesRatingTextBox_TextChanged);
            // 
            // MoviesRatingLabel
            // 
            this.MoviesRatingLabel.AutoSize = true;
            this.MoviesRatingLabel.Location = new System.Drawing.Point(133, 81);
            this.MoviesRatingLabel.Name = "MoviesRatingLabel";
            this.MoviesRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.MoviesRatingLabel.TabIndex = 10;
            this.MoviesRatingLabel.Text = "Rating:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Items.AddRange(new object[] {
            "Movie 1",
            "Movie 2",
            "Movie 3",
            "Movie 4",
            "Movie 5",
            "Movie 6",
            "Movie 7",
            "Movie 8",
            "Movie 9",
            "Movie 10"});
            this.MoviesListBox.Location = new System.Drawing.Point(3, 3);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(127, 277);
            this.MoviesListBox.TabIndex = 9;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoviesFindButton);
            this.Controls.Add(this.MoviesYearTextBox);
            this.Controls.Add(this.MoviesYearLabel);
            this.Controls.Add(this.MoviesTitleTextBox);
            this.Controls.Add(this.MoviesTitleLabel);
            this.Controls.Add(this.MoviesRatingTextBox);
            this.Controls.Add(this.MoviesRatingLabel);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "Movies";
            this.Size = new System.Drawing.Size(240, 284);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoviesFindButton;
        private System.Windows.Forms.TextBox MoviesYearTextBox;
        private System.Windows.Forms.Label MoviesYearLabel;
        private System.Windows.Forms.TextBox MoviesTitleTextBox;
        private System.Windows.Forms.Label MoviesTitleLabel;
        private System.Windows.Forms.TextBox MoviesRatingTextBox;
        private System.Windows.Forms.Label MoviesRatingLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
