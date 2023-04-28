namespace WindowsFormsApp1
{
    partial class ActionSelector
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
            this.UXTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UxDeleteButton = new System.Windows.Forms.Button();
            this.UXCommentsLabel = new System.Windows.Forms.Label();
            this.UXUpdateBtn = new System.Windows.Forms.Button();
            this.UXAddBtn = new System.Windows.Forms.Button();
            this.UXComments = new System.Windows.Forms.TextBox();
            this.UXRatingLabel = new System.Windows.Forms.Label();
            this.uxRatingNumber = new System.Windows.Forms.NumericUpDown();
            this.uxMovieName = new System.Windows.Forms.TextBox();
            this.UXPersonalReviews = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UXRottenTomatoesRating = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UXPersonalRatingQuery = new System.Windows.Forms.TextBox();
            this.UXPersonalReviewLabel = new System.Windows.Forms.Label();
            this.UXImdbScoreLabel = new System.Windows.Forms.Label();
            this.UxIMDBScore = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UxMovieLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UxActorsResultBox = new System.Windows.Forms.ListBox();
            this.UxEndMonth = new System.Windows.Forms.MonthCalendar();
            this.UxBeginMonth = new System.Windows.Forms.MonthCalendar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.UXProfitResultBox = new System.Windows.Forms.ListBox();
            this.UxGenreSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.UXGenreResultListBox = new System.Windows.Forms.ListBox();
            this.UxGenreBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.UxAddMovies = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ux_MoviesList = new System.Windows.Forms.TabPage();
            this.ux_MovieDataGrid = new System.Windows.Forms.DataGridView();
            this.ux_populateButton = new System.Windows.Forms.Button();
            this.UXTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxRatingNumber)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.ux_MoviesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ux_MovieDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UXTabControl
            // 
            this.UXTabControl.Controls.Add(this.tabPage1);
            this.UXTabControl.Controls.Add(this.tabPage2);
            this.UXTabControl.Controls.Add(this.tabPage3);
            this.UXTabControl.Controls.Add(this.tabPage4);
            this.UXTabControl.Controls.Add(this.tabPage5);
            this.UXTabControl.Controls.Add(this.tabPage6);
            this.UXTabControl.Controls.Add(this.ux_MoviesList);
            this.UXTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UXTabControl.Location = new System.Drawing.Point(4, 2);
            this.UXTabControl.Name = "UXTabControl";
            this.UXTabControl.SelectedIndex = 0;
            this.UXTabControl.Size = new System.Drawing.Size(784, 446);
            this.UXTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UxDeleteButton);
            this.tabPage1.Controls.Add(this.UXCommentsLabel);
            this.tabPage1.Controls.Add(this.UXUpdateBtn);
            this.tabPage1.Controls.Add(this.UXAddBtn);
            this.tabPage1.Controls.Add(this.UXComments);
            this.tabPage1.Controls.Add(this.UXRatingLabel);
            this.tabPage1.Controls.Add(this.uxRatingNumber);
            this.tabPage1.Controls.Add(this.uxMovieName);
            this.tabPage1.Controls.Add(this.UXPersonalReviews);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Review";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UxDeleteButton
            // 
            this.UxDeleteButton.Location = new System.Drawing.Point(631, 378);
            this.UxDeleteButton.Name = "UxDeleteButton";
            this.UxDeleteButton.Size = new System.Drawing.Size(118, 33);
            this.UxDeleteButton.TabIndex = 8;
            this.UxDeleteButton.Text = "Delete";
            this.UxDeleteButton.UseVisualStyleBackColor = true;
            this.UxDeleteButton.Click += new System.EventHandler(this.UxDeleteButton_Click);
            // 
            // UXCommentsLabel
            // 
            this.UXCommentsLabel.AutoSize = true;
            this.UXCommentsLabel.Location = new System.Drawing.Point(168, 111);
            this.UXCommentsLabel.Name = "UXCommentsLabel";
            this.UXCommentsLabel.Size = new System.Drawing.Size(83, 16);
            this.UXCommentsLabel.TabIndex = 7;
            this.UXCommentsLabel.Text = "Comments:";
            this.UXCommentsLabel.UseMnemonic = false;
            // 
            // UXUpdateBtn
            // 
            this.UXUpdateBtn.Location = new System.Drawing.Point(302, 378);
            this.UXUpdateBtn.Name = "UXUpdateBtn";
            this.UXUpdateBtn.Size = new System.Drawing.Size(172, 33);
            this.UXUpdateBtn.TabIndex = 6;
            this.UXUpdateBtn.Text = "Update";
            this.UXUpdateBtn.UseVisualStyleBackColor = true;
            this.UXUpdateBtn.Click += new System.EventHandler(this.Update_Click);
            // 
            // UXAddBtn
            // 
            this.UXAddBtn.Location = new System.Drawing.Point(10, 378);
            this.UXAddBtn.Name = "UXAddBtn";
            this.UXAddBtn.Size = new System.Drawing.Size(117, 36);
            this.UXAddBtn.TabIndex = 5;
            this.UXAddBtn.Text = "Add";
            this.UXAddBtn.UseVisualStyleBackColor = true;
            this.UXAddBtn.Click += new System.EventHandler(this.UXAddBtn_Click);
            // 
            // UXComments
            // 
            this.UXComments.AcceptsReturn = true;
            this.UXComments.Location = new System.Drawing.Point(168, 130);
            this.UXComments.Multiline = true;
            this.UXComments.Name = "UXComments";
            this.UXComments.Size = new System.Drawing.Size(592, 238);
            this.UXComments.TabIndex = 4;
            // 
            // UXRatingLabel
            // 
            this.UXRatingLabel.AutoSize = true;
            this.UXRatingLabel.Location = new System.Drawing.Point(7, 111);
            this.UXRatingLabel.Name = "UXRatingLabel";
            this.UXRatingLabel.Size = new System.Drawing.Size(56, 16);
            this.UXRatingLabel.TabIndex = 3;
            this.UXRatingLabel.Text = "Rating:";
            // 
            // uxRatingNumber
            // 
            this.uxRatingNumber.Location = new System.Drawing.Point(7, 130);
            this.uxRatingNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uxRatingNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxRatingNumber.Name = "uxRatingNumber";
            this.uxRatingNumber.Size = new System.Drawing.Size(120, 22);
            this.uxRatingNumber.TabIndex = 2;
            this.uxRatingNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxMovieName
            // 
            this.uxMovieName.Location = new System.Drawing.Point(7, 48);
            this.uxMovieName.Name = "uxMovieName";
            this.uxMovieName.Size = new System.Drawing.Size(753, 22);
            this.uxMovieName.TabIndex = 1;
            // 
            // UXPersonalReviews
            // 
            this.UXPersonalReviews.FormattingEnabled = true;
            this.UXPersonalReviews.Location = new System.Drawing.Point(6, 17);
            this.UXPersonalReviews.Name = "UXPersonalReviews";
            this.UXPersonalReviews.Size = new System.Drawing.Size(754, 24);
            this.UXPersonalReviews.TabIndex = 0;
            this.UXPersonalReviews.SelectedIndexChanged += new System.EventHandler(this.UXPersonalReviews_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UXRottenTomatoesRating);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.UXPersonalRatingQuery);
            this.tabPage2.Controls.Add(this.UXPersonalReviewLabel);
            this.tabPage2.Controls.Add(this.UXImdbScoreLabel);
            this.tabPage2.Controls.Add(this.UxIMDBScore);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.UxMovieLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compare Ratings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UXRottenTomatoesRating
            // 
            this.UXRottenTomatoesRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UXRottenTomatoesRating.Location = new System.Drawing.Point(578, 143);
            this.UXRottenTomatoesRating.Name = "UXRottenTomatoesRating";
            this.UXRottenTomatoesRating.Size = new System.Drawing.Size(41, 38);
            this.UXRottenTomatoesRating.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rotten Tomatoes";
            // 
            // UXPersonalRatingQuery
            // 
            this.UXPersonalRatingQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UXPersonalRatingQuery.Location = new System.Drawing.Point(79, 143);
            this.UXPersonalRatingQuery.Name = "UXPersonalRatingQuery";
            this.UXPersonalRatingQuery.Size = new System.Drawing.Size(41, 38);
            this.UXPersonalRatingQuery.TabIndex = 5;
            // 
            // UXPersonalReviewLabel
            // 
            this.UXPersonalReviewLabel.AutoSize = true;
            this.UXPersonalReviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UXPersonalReviewLabel.Location = new System.Drawing.Point(41, 120);
            this.UXPersonalReviewLabel.Name = "UXPersonalReviewLabel";
            this.UXPersonalReviewLabel.Size = new System.Drawing.Size(105, 20);
            this.UXPersonalReviewLabel.TabIndex = 4;
            this.UXPersonalReviewLabel.Text = "Your Rating";
            this.UXPersonalReviewLabel.Click += new System.EventHandler(this.UXPersonalReviewLabel_Click);
            // 
            // UXImdbScoreLabel
            // 
            this.UXImdbScoreLabel.AutoSize = true;
            this.UXImdbScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UXImdbScoreLabel.Location = new System.Drawing.Point(309, 120);
            this.UXImdbScoreLabel.Name = "UXImdbScoreLabel";
            this.UXImdbScoreLabel.Size = new System.Drawing.Size(54, 20);
            this.UXImdbScoreLabel.TabIndex = 3;
            this.UXImdbScoreLabel.Text = "IMDB";
            // 
            // UxIMDBScore
            // 
            this.UxIMDBScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxIMDBScore.Location = new System.Drawing.Point(313, 143);
            this.UxIMDBScore.Name = "UxIMDBScore";
            this.UxIMDBScore.Size = new System.Drawing.Size(41, 38);
            this.UxIMDBScore.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(765, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // UxMovieLabel
            // 
            this.UxMovieLabel.AutoSize = true;
            this.UxMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxMovieLabel.Location = new System.Drawing.Point(6, 19);
            this.UxMovieLabel.Name = "UxMovieLabel";
            this.UxMovieLabel.Size = new System.Drawing.Size(94, 20);
            this.UxMovieLabel.TabIndex = 0;
            this.UxMovieLabel.Text = "Movie Title";
            this.UxMovieLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.UxActorsResultBox);
            this.tabPage3.Controls.Add(this.UxEndMonth);
            this.tabPage3.Controls.Add(this.UxBeginMonth);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(776, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Actors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date";
            // 
            // UxActorsResultBox
            // 
            this.UxActorsResultBox.FormattingEnabled = true;
            this.UxActorsResultBox.ItemHeight = 16;
            this.UxActorsResultBox.Location = new System.Drawing.Point(3, 231);
            this.UxActorsResultBox.Name = "UxActorsResultBox";
            this.UxActorsResultBox.Size = new System.Drawing.Size(768, 180);
            this.UxActorsResultBox.TabIndex = 2;
            // 
            // UxEndMonth
            // 
            this.UxEndMonth.Location = new System.Drawing.Point(540, 66);
            this.UxEndMonth.Name = "UxEndMonth";
            this.UxEndMonth.TabIndex = 1;
            // 
            // UxBeginMonth
            // 
            this.UxBeginMonth.Location = new System.Drawing.Point(3, 66);
            this.UxBeginMonth.Name = "UxBeginMonth";
            this.UxBeginMonth.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.UXProfitResultBox);
            this.tabPage4.Controls.Add(this.UxGenreSelect);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(776, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Profit";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // UXProfitResultBox
            // 
            this.UXProfitResultBox.FormattingEnabled = true;
            this.UXProfitResultBox.ItemHeight = 16;
            this.UXProfitResultBox.Location = new System.Drawing.Point(5, 145);
            this.UXProfitResultBox.Name = "UXProfitResultBox";
            this.UXProfitResultBox.Size = new System.Drawing.Size(768, 260);
            this.UXProfitResultBox.TabIndex = 2;
            // 
            // UxGenreSelect
            // 
            this.UxGenreSelect.FormattingEnabled = true;
            this.UxGenreSelect.Location = new System.Drawing.Point(55, 103);
            this.UxGenreSelect.Name = "UxGenreSelect";
            this.UxGenreSelect.Size = new System.Drawing.Size(121, 24);
            this.UxGenreSelect.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Genre";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.UXGenreResultListBox);
            this.tabPage5.Controls.Add(this.UxGenreBox);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(776, 417);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Genre";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // UXGenreResultListBox
            // 
            this.UXGenreResultListBox.FormattingEnabled = true;
            this.UXGenreResultListBox.ItemHeight = 16;
            this.UXGenreResultListBox.Location = new System.Drawing.Point(4, 167);
            this.UXGenreResultListBox.Name = "UXGenreResultListBox";
            this.UXGenreResultListBox.Size = new System.Drawing.Size(768, 244);
            this.UXGenreResultListBox.TabIndex = 2;
            // 
            // UxGenreBox
            // 
            this.UxGenreBox.FormattingEnabled = true;
            this.UxGenreBox.Location = new System.Drawing.Point(33, 85);
            this.UxGenreBox.Name = "UxGenreBox";
            this.UxGenreBox.Size = new System.Drawing.Size(121, 24);
            this.UxGenreBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.UxAddMovies);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(776, 417);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "AddMovies";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // UxAddMovies
            // 
            this.UxAddMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxAddMovies.Location = new System.Drawing.Point(283, 145);
            this.UxAddMovies.Name = "UxAddMovies";
            this.UxAddMovies.Size = new System.Drawing.Size(167, 87);
            this.UxAddMovies.TabIndex = 0;
            this.UxAddMovies.Text = "Add Movies";
            this.UxAddMovies.UseVisualStyleBackColor = true;
            this.UxAddMovies.Click += new System.EventHandler(this.UxAddMovies_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ux_MoviesList
            // 
            this.ux_MoviesList.Controls.Add(this.ux_populateButton);
            this.ux_MoviesList.Controls.Add(this.ux_MovieDataGrid);
            this.ux_MoviesList.Location = new System.Drawing.Point(4, 25);
            this.ux_MoviesList.Name = "ux_MoviesList";
            this.ux_MoviesList.Padding = new System.Windows.Forms.Padding(3);
            this.ux_MoviesList.Size = new System.Drawing.Size(776, 417);
            this.ux_MoviesList.TabIndex = 6;
            this.ux_MoviesList.Text = "Movies List";
            this.ux_MoviesList.UseVisualStyleBackColor = true;
            // 
            // ux_MovieDataGrid
            // 
            this.ux_MovieDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ux_MovieDataGrid.Location = new System.Drawing.Point(3, 142);
            this.ux_MovieDataGrid.Name = "ux_MovieDataGrid";
            this.ux_MovieDataGrid.Size = new System.Drawing.Size(767, 269);
            this.ux_MovieDataGrid.TabIndex = 0;
            // 
            // ux_populateButton
            // 
            this.ux_populateButton.Location = new System.Drawing.Point(6, 6);
            this.ux_populateButton.Name = "ux_populateButton";
            this.ux_populateButton.Size = new System.Drawing.Size(175, 43);
            this.ux_populateButton.TabIndex = 1;
            this.ux_populateButton.Text = "Populate Movie List";
            this.ux_populateButton.UseVisualStyleBackColor = true;
            this.ux_populateButton.Click += new System.EventHandler(this.ux_populateButton_Click);
            // 
            // ActionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UXTabControl);
            this.Name = "ActionSelector";
            this.Text = "ActionSelector";
            this.Load += new System.EventHandler(this.ActionSelector_Load);
            this.UXTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxRatingNumber)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.ux_MoviesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ux_MovieDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UXTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox UXPersonalReviews;
        private System.Windows.Forms.TextBox uxMovieName;
        private System.Windows.Forms.NumericUpDown uxRatingNumber;
        private System.Windows.Forms.Label UXRatingLabel;
        private System.Windows.Forms.TextBox UXComments;
        private System.Windows.Forms.Button UXUpdateBtn;
        private System.Windows.Forms.Button UXAddBtn;
        private System.Windows.Forms.Button UxDeleteButton;
        private System.Windows.Forms.Label UXCommentsLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label UxMovieLabel;
        private System.Windows.Forms.TextBox UXPersonalRatingQuery;
        private System.Windows.Forms.Label UXPersonalReviewLabel;
        private System.Windows.Forms.Label UXImdbScoreLabel;
        private System.Windows.Forms.TextBox UxIMDBScore;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox UXRottenTomatoesRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button UxAddMovies;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox UXGenreResultListBox;
        private System.Windows.Forms.ComboBox UxGenreBox;
        private System.Windows.Forms.ListBox UXProfitResultBox;
        private System.Windows.Forms.ComboBox UxGenreSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox UxActorsResultBox;
        private System.Windows.Forms.MonthCalendar UxEndMonth;
        private System.Windows.Forms.MonthCalendar UxBeginMonth;
        private System.Windows.Forms.TabPage ux_MoviesList;
        private System.Windows.Forms.Button ux_populateButton;
        private System.Windows.Forms.DataGridView ux_MovieDataGrid;
    }
}