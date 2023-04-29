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
            this.components = new System.ComponentModel.Container();
            this.ux_TabControl = new System.Windows.Forms.TabControl();
            this.ux_MoviesList = new System.Windows.Forms.TabPage();
            this.uxCostTextBox = new System.Windows.Forms.TextBox();
            this.uxCostLabel = new System.Windows.Forms.Label();
            this.uxInternationalTextBox = new System.Windows.Forms.TextBox();
            this.uxInternationalLabel = new System.Windows.Forms.Label();
            this.uxDomesticTextBox = new System.Windows.Forms.TextBox();
            this.uxDomesticLabel = new System.Windows.Forms.Label();
            this.uxGenreTextBox = new System.Windows.Forms.TextBox();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxStudioTextBox = new System.Windows.Forms.TextBox();
            this.uxStudioLabel = new System.Windows.Forms.Label();
            this.uxAddRoleButton = new System.Windows.Forms.Button();
            this.uxAddPersonalRatingButton = new System.Windows.Forms.Button();
            this.uxAddMovie = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxMoviesList = new System.Windows.Forms.ListBox();
            this.uxMovieTitleLabel = new System.Windows.Forms.Label();
            this.uxGetAllMovies = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.ux_AddMovies = new System.Windows.Forms.TabPage();
            this.UxAddMovies = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxReviewsPerMovie = new System.Windows.Forms.Label();
            this.uxReviewsForMovieListBox = new System.Windows.Forms.ListBox();
            this.uxMovieListComboBox = new System.Windows.Forms.ComboBox();
            this.ux_TabControl.SuspendLayout();
            this.ux_MoviesList.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.ux_AddMovies.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ux_TabControl
            // 
            this.ux_TabControl.Controls.Add(this.ux_MoviesList);
            this.ux_TabControl.Controls.Add(this.tabPage1);
            this.ux_TabControl.Controls.Add(this.tabPage2);
            this.ux_TabControl.Controls.Add(this.tabPage3);
            this.ux_TabControl.Controls.Add(this.tabPage4);
            this.ux_TabControl.Controls.Add(this.tabPage5);
            this.ux_TabControl.Controls.Add(this.ux_AddMovies);
            this.ux_TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_TabControl.Location = new System.Drawing.Point(4, 2);
            this.ux_TabControl.Name = "ux_TabControl";
            this.ux_TabControl.SelectedIndex = 0;
            this.ux_TabControl.Size = new System.Drawing.Size(784, 446);
            this.ux_TabControl.TabIndex = 3;
            // 
            // ux_MoviesList
            // 
            this.ux_MoviesList.Controls.Add(this.uxCostTextBox);
            this.ux_MoviesList.Controls.Add(this.uxCostLabel);
            this.ux_MoviesList.Controls.Add(this.uxInternationalTextBox);
            this.ux_MoviesList.Controls.Add(this.uxInternationalLabel);
            this.ux_MoviesList.Controls.Add(this.uxDomesticTextBox);
            this.ux_MoviesList.Controls.Add(this.uxDomesticLabel);
            this.ux_MoviesList.Controls.Add(this.uxGenreTextBox);
            this.ux_MoviesList.Controls.Add(this.uxGenreLabel);
            this.ux_MoviesList.Controls.Add(this.uxStudioTextBox);
            this.ux_MoviesList.Controls.Add(this.uxStudioLabel);
            this.ux_MoviesList.Controls.Add(this.uxAddRoleButton);
            this.ux_MoviesList.Controls.Add(this.uxAddPersonalRatingButton);
            this.ux_MoviesList.Controls.Add(this.uxAddMovie);
            this.ux_MoviesList.Controls.Add(this.textBox1);
            this.ux_MoviesList.Controls.Add(this.uxMoviesList);
            this.ux_MoviesList.Controls.Add(this.uxMovieTitleLabel);
            this.ux_MoviesList.Controls.Add(this.uxGetAllMovies);
            this.ux_MoviesList.Location = new System.Drawing.Point(4, 25);
            this.ux_MoviesList.Name = "ux_MoviesList";
            this.ux_MoviesList.Padding = new System.Windows.Forms.Padding(3);
            this.ux_MoviesList.Size = new System.Drawing.Size(776, 417);
            this.ux_MoviesList.TabIndex = 6;
            this.ux_MoviesList.Text = "Movies List";
            this.ux_MoviesList.UseVisualStyleBackColor = true;
            // 
            // uxCostTextBox
            // 
            this.uxCostTextBox.Location = new System.Drawing.Point(395, 256);
            this.uxCostTextBox.Name = "uxCostTextBox";
            this.uxCostTextBox.Size = new System.Drawing.Size(174, 22);
            this.uxCostTextBox.TabIndex = 18;
            // 
            // uxCostLabel
            // 
            this.uxCostLabel.AutoSize = true;
            this.uxCostLabel.Location = new System.Drawing.Point(395, 235);
            this.uxCostLabel.Name = "uxCostLabel";
            this.uxCostLabel.Size = new System.Drawing.Size(116, 16);
            this.uxCostLabel.TabIndex = 17;
            this.uxCostLabel.Text = "Production Cost";
            // 
            // uxInternationalTextBox
            // 
            this.uxInternationalTextBox.Location = new System.Drawing.Point(395, 196);
            this.uxInternationalTextBox.Name = "uxInternationalTextBox";
            this.uxInternationalTextBox.Size = new System.Drawing.Size(174, 22);
            this.uxInternationalTextBox.TabIndex = 16;
            // 
            // uxInternationalLabel
            // 
            this.uxInternationalLabel.AutoSize = true;
            this.uxInternationalLabel.Location = new System.Drawing.Point(395, 175);
            this.uxInternationalLabel.Name = "uxInternationalLabel";
            this.uxInternationalLabel.Size = new System.Drawing.Size(149, 16);
            this.uxInternationalLabel.TabIndex = 15;
            this.uxInternationalLabel.Text = "Internationl Revenue";
            // 
            // uxDomesticTextBox
            // 
            this.uxDomesticTextBox.Location = new System.Drawing.Point(395, 135);
            this.uxDomesticTextBox.Name = "uxDomesticTextBox";
            this.uxDomesticTextBox.Size = new System.Drawing.Size(174, 22);
            this.uxDomesticTextBox.TabIndex = 14;
            // 
            // uxDomesticLabel
            // 
            this.uxDomesticLabel.AutoSize = true;
            this.uxDomesticLabel.Location = new System.Drawing.Point(395, 116);
            this.uxDomesticLabel.Name = "uxDomesticLabel";
            this.uxDomesticLabel.Size = new System.Drawing.Size(138, 16);
            this.uxDomesticLabel.TabIndex = 13;
            this.uxDomesticLabel.Text = "Domestic Revenue";
            // 
            // uxGenreTextBox
            // 
            this.uxGenreTextBox.Location = new System.Drawing.Point(395, 77);
            this.uxGenreTextBox.Name = "uxGenreTextBox";
            this.uxGenreTextBox.Size = new System.Drawing.Size(174, 22);
            this.uxGenreTextBox.TabIndex = 12;
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Location = new System.Drawing.Point(395, 58);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(49, 16);
            this.uxGenreLabel.TabIndex = 11;
            this.uxGenreLabel.Text = "Genre";
            // 
            // uxStudioTextBox
            // 
            this.uxStudioTextBox.Location = new System.Drawing.Point(395, 23);
            this.uxStudioTextBox.Name = "uxStudioTextBox";
            this.uxStudioTextBox.Size = new System.Drawing.Size(174, 22);
            this.uxStudioTextBox.TabIndex = 10;
            // 
            // uxStudioLabel
            // 
            this.uxStudioLabel.AutoSize = true;
            this.uxStudioLabel.Location = new System.Drawing.Point(392, 3);
            this.uxStudioLabel.Name = "uxStudioLabel";
            this.uxStudioLabel.Size = new System.Drawing.Size(51, 16);
            this.uxStudioLabel.TabIndex = 9;
            this.uxStudioLabel.Text = "Studio";
            // 
            // uxAddRoleButton
            // 
            this.uxAddRoleButton.Location = new System.Drawing.Point(595, 235);
            this.uxAddRoleButton.Name = "uxAddRoleButton";
            this.uxAddRoleButton.Size = new System.Drawing.Size(175, 43);
            this.uxAddRoleButton.TabIndex = 8;
            this.uxAddRoleButton.Text = "Add Role";
            this.uxAddRoleButton.UseVisualStyleBackColor = true;
            this.uxAddRoleButton.Click += new System.EventHandler(this.uxAddRoleButton_Click);
            // 
            // uxAddPersonalRatingButton
            // 
            this.uxAddPersonalRatingButton.Location = new System.Drawing.Point(595, 175);
            this.uxAddPersonalRatingButton.Name = "uxAddPersonalRatingButton";
            this.uxAddPersonalRatingButton.Size = new System.Drawing.Size(175, 43);
            this.uxAddPersonalRatingButton.TabIndex = 7;
            this.uxAddPersonalRatingButton.Text = "Add Review";
            this.uxAddPersonalRatingButton.UseVisualStyleBackColor = true;
            this.uxAddPersonalRatingButton.Click += new System.EventHandler(this.uxAddPersonalRatingButton_Click);
            // 
            // uxAddMovie
            // 
            this.uxAddMovie.Location = new System.Drawing.Point(595, 116);
            this.uxAddMovie.Name = "uxAddMovie";
            this.uxAddMovie.Size = new System.Drawing.Size(175, 43);
            this.uxAddMovie.TabIndex = 6;
            this.uxAddMovie.Text = "Add Movie";
            this.uxAddMovie.UseVisualStyleBackColor = true;
            this.uxAddMovie.Click += new System.EventHandler(this.uxAddMovie_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(596, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uxMoviesList
            // 
            this.uxMoviesList.FormattingEnabled = true;
            this.uxMoviesList.ItemHeight = 16;
            this.uxMoviesList.Location = new System.Drawing.Point(0, 0);
            this.uxMoviesList.Name = "uxMoviesList";
            this.uxMoviesList.Size = new System.Drawing.Size(389, 420);
            this.uxMoviesList.TabIndex = 2;
            this.uxMoviesList.SelectedIndexChanged += new System.EventHandler(this.uxMoviesList_SelectedIndexChanged);
            // 
            // uxMovieTitleLabel
            // 
            this.uxMovieTitleLabel.AutoSize = true;
            this.uxMovieTitleLabel.Location = new System.Drawing.Point(593, 3);
            this.uxMovieTitleLabel.Name = "uxMovieTitleLabel";
            this.uxMovieTitleLabel.Size = new System.Drawing.Size(56, 16);
            this.uxMovieTitleLabel.TabIndex = 3;
            this.uxMovieTitleLabel.Text = "Search";
            // 
            // uxGetAllMovies
            // 
            this.uxGetAllMovies.Location = new System.Drawing.Point(595, 58);
            this.uxGetAllMovies.Name = "uxGetAllMovies";
            this.uxGetAllMovies.Size = new System.Drawing.Size(175, 43);
            this.uxGetAllMovies.TabIndex = 1;
            this.uxGetAllMovies.Text = "Get All Movies";
            this.uxGetAllMovies.UseVisualStyleBackColor = true;
            this.uxGetAllMovies.Click += new System.EventHandler(this.uxGetAllMovies_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uxMovieListComboBox);
            this.tabPage1.Controls.Add(this.uxReviewsForMovieListBox);
            this.tabPage1.Controls.Add(this.uxReviewsPerMovie);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Review";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage5.Text = "Genres";
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
            // 
            // ux_AddMovies
            // 
            this.ux_AddMovies.Controls.Add(this.UxAddMovies);
            this.ux_AddMovies.Location = new System.Drawing.Point(4, 25);
            this.ux_AddMovies.Name = "ux_AddMovies";
            this.ux_AddMovies.Size = new System.Drawing.Size(776, 417);
            this.ux_AddMovies.TabIndex = 5;
            this.ux_AddMovies.Text = "AddMovies";
            this.ux_AddMovies.UseVisualStyleBackColor = true;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // uxReviewsPerMovie
            // 
            this.uxReviewsPerMovie.AutoSize = true;
            this.uxReviewsPerMovie.Location = new System.Drawing.Point(6, 13);
            this.uxReviewsPerMovie.Name = "uxReviewsPerMovie";
            this.uxReviewsPerMovie.Size = new System.Drawing.Size(144, 16);
            this.uxReviewsPerMovie.TabIndex = 10;
            this.uxReviewsPerMovie.Text = "See Movie Reviews";
            // 
            // uxReviewsForMovieListBox
            // 
            this.uxReviewsForMovieListBox.FormattingEnabled = true;
            this.uxReviewsForMovieListBox.ItemHeight = 16;
            this.uxReviewsForMovieListBox.Location = new System.Drawing.Point(0, 80);
            this.uxReviewsForMovieListBox.Name = "uxReviewsForMovieListBox";
            this.uxReviewsForMovieListBox.Size = new System.Drawing.Size(776, 340);
            this.uxReviewsForMovieListBox.TabIndex = 11;
            // 
            // uxMovieListComboBox
            // 
            this.uxMovieListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieListComboBox.FormattingEnabled = true;
            this.uxMovieListComboBox.Location = new System.Drawing.Point(9, 32);
            this.uxMovieListComboBox.Name = "uxMovieListComboBox";
            this.uxMovieListComboBox.Size = new System.Drawing.Size(343, 33);
            this.uxMovieListComboBox.TabIndex = 30;
            this.uxMovieListComboBox.SelectedValueChanged += new System.EventHandler(this.uxMovieListComboBox_SelectedValueChanged);
            // 
            // ActionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.ux_TabControl);
            this.Name = "ActionSelector";
            this.Text = "ActionSelector";
            this.ux_TabControl.ResumeLayout(false);
            this.ux_MoviesList.ResumeLayout(false);
            this.ux_MoviesList.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ux_AddMovies.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ux_TabControl;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TabPage ux_AddMovies;
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
        private System.Windows.Forms.Button uxGetAllMovies;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ListBox uxMoviesList;
        private System.Windows.Forms.Label uxMovieTitleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button uxAddMovie;
        private System.Windows.Forms.Button uxAddRoleButton;
        private System.Windows.Forms.Button uxAddPersonalRatingButton;
        private System.Windows.Forms.Label uxStudioLabel;
        private System.Windows.Forms.TextBox uxCostTextBox;
        private System.Windows.Forms.Label uxCostLabel;
        private System.Windows.Forms.TextBox uxInternationalTextBox;
        private System.Windows.Forms.Label uxInternationalLabel;
        private System.Windows.Forms.TextBox uxDomesticTextBox;
        private System.Windows.Forms.Label uxDomesticLabel;
        private System.Windows.Forms.TextBox uxGenreTextBox;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.TextBox uxStudioTextBox;
        private System.Windows.Forms.ListBox uxReviewsForMovieListBox;
        private System.Windows.Forms.Label uxReviewsPerMovie;
        private System.Windows.Forms.ComboBox uxMovieListComboBox;
    }
}