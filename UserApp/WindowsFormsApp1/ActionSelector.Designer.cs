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
            this.ux_GenresTab = new System.Windows.Forms.TabPage();
            this.ux_GenrePopulateButton = new System.Windows.Forms.Button();
            this.ux_GenresDataView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uxMovieListComboBox = new System.Windows.Forms.ComboBox();
            this.uxReviewsForMovieListBox = new System.Windows.Forms.ListBox();
            this.uxReviewsPerMovie = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ux_CalcHighestPaidWithin = new System.Windows.Forms.Button();
            this.ux_HighestPaidWithinData = new System.Windows.Forms.DataGridView();
            this.ux_EndDatePicker = new System.Windows.Forms.NumericUpDown();
            this.ux_StartDatePicker = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ux_AverageProfitByStudioandGenre = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.ux_dad = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ux_GenrePicker = new System.Windows.Forms.NumericUpDown();
            this.ux_ASPbGDataGrid = new System.Windows.Forms.DataGridView();
            this.ux_ASPbGButton = new System.Windows.Forms.Button();
            this.ux_APCbGButton = new System.Windows.Forms.Button();
            this.ux_APCbGDataGrid = new System.Windows.Forms.DataGridView();
            this.ux_APCbGGenrePicker = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.uxAddUserButton = new System.Windows.Forms.Button();
            this.ux_MovieBox = new System.Windows.Forms.ComboBox();
            this.ux_MovieCompareDataGrid = new System.Windows.Forms.DataGridView();
            this.ux_MovieCompareButton = new System.Windows.Forms.Button();
            this.ux_ReviewRefresh = new System.Windows.Forms.Button();
            this.ux_CompareRefresh = new System.Windows.Forms.Button();
            this.ux_TabControl.SuspendLayout();
            this.ux_MoviesList.SuspendLayout();
            this.ux_GenresTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ux_GenresDataView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ux_HighestPaidWithinData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_EndDatePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_StartDatePicker)).BeginInit();
            this.ux_AverageProfitByStudioandGenre.SuspendLayout();
            this.ux_dad.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ux_GenrePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_ASPbGDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_APCbGDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_APCbGGenrePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_MovieCompareDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_TabControl
            // 
            this.ux_TabControl.Controls.Add(this.ux_MoviesList);
            this.ux_TabControl.Controls.Add(this.ux_GenresTab);
            this.ux_TabControl.Controls.Add(this.tabPage1);
            this.ux_TabControl.Controls.Add(this.tabPage2);
            this.ux_TabControl.Controls.Add(this.tabPage3);
            this.ux_TabControl.Controls.Add(this.ux_AverageProfitByStudioandGenre);
            this.ux_TabControl.Controls.Add(this.ux_dad);
            this.ux_TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_TabControl.Location = new System.Drawing.Point(4, 2);
            this.ux_TabControl.Name = "ux_TabControl";
            this.ux_TabControl.SelectedIndex = 0;
            this.ux_TabControl.Size = new System.Drawing.Size(784, 446);
            this.ux_TabControl.TabIndex = 3;
            // 
            // ux_MoviesList
            // 
            this.ux_MoviesList.Controls.Add(this.uxAddUserButton);
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
            // ux_GenresTab
            // 
            this.ux_GenresTab.Controls.Add(this.ux_GenrePopulateButton);
            this.ux_GenresTab.Controls.Add(this.ux_GenresDataView);
            this.ux_GenresTab.Location = new System.Drawing.Point(4, 25);
            this.ux_GenresTab.Name = "ux_GenresTab";
            this.ux_GenresTab.Size = new System.Drawing.Size(776, 417);
            this.ux_GenresTab.TabIndex = 4;
            this.ux_GenresTab.Text = "Genres";
            this.ux_GenresTab.UseVisualStyleBackColor = true;
            // 
            // ux_GenrePopulateButton
            // 
            this.ux_GenrePopulateButton.Location = new System.Drawing.Point(4, 3);
            this.ux_GenrePopulateButton.Name = "ux_GenrePopulateButton";
            this.ux_GenrePopulateButton.Size = new System.Drawing.Size(169, 37);
            this.ux_GenrePopulateButton.TabIndex = 3;
            this.ux_GenrePopulateButton.Text = "Populate Genres List";
            this.ux_GenrePopulateButton.UseVisualStyleBackColor = true;
            this.ux_GenrePopulateButton.Click += new System.EventHandler(this.ux_GenrePopulateButton_Click);
            // 
            // ux_GenresDataView
            // 
            this.ux_GenresDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ux_GenresDataView.Location = new System.Drawing.Point(4, 46);
            this.ux_GenresDataView.Name = "ux_GenresDataView";
            this.ux_GenresDataView.Size = new System.Drawing.Size(767, 365);
            this.ux_GenresDataView.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ux_ReviewRefresh);
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
            // uxReviewsForMovieListBox
            // 
            this.uxReviewsForMovieListBox.FormattingEnabled = true;
            this.uxReviewsForMovieListBox.ItemHeight = 16;
            this.uxReviewsForMovieListBox.Location = new System.Drawing.Point(0, 80);
            this.uxReviewsForMovieListBox.Name = "uxReviewsForMovieListBox";
            this.uxReviewsForMovieListBox.Size = new System.Drawing.Size(776, 340);
            this.uxReviewsForMovieListBox.TabIndex = 11;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ux_CompareRefresh);
            this.tabPage2.Controls.Add(this.ux_MovieCompareButton);
            this.tabPage2.Controls.Add(this.ux_MovieCompareDataGrid);
            this.tabPage2.Controls.Add(this.ux_MovieBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compare Ratings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ux_CalcHighestPaidWithin);
            this.tabPage3.Controls.Add(this.ux_HighestPaidWithinData);
            this.tabPage3.Controls.Add(this.ux_EndDatePicker);
            this.tabPage3.Controls.Add(this.ux_StartDatePicker);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(776, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Actors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ux_CalcHighestPaidWithin
            // 
            this.ux_CalcHighestPaidWithin.Location = new System.Drawing.Point(225, 34);
            this.ux_CalcHighestPaidWithin.Name = "ux_CalcHighestPaidWithin";
            this.ux_CalcHighestPaidWithin.Size = new System.Drawing.Size(330, 30);
            this.ux_CalcHighestPaidWithin.TabIndex = 8;
            this.ux_CalcHighestPaidWithin.Text = "Calculate Highest Paid Actor Between Dates";
            this.ux_CalcHighestPaidWithin.UseVisualStyleBackColor = true;
            this.ux_CalcHighestPaidWithin.Click += new System.EventHandler(this.ux_CalcHighestPaidWithin_Click);
            // 
            // ux_HighestPaidWithinData
            // 
            this.ux_HighestPaidWithinData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ux_HighestPaidWithinData.Location = new System.Drawing.Point(8, 88);
            this.ux_HighestPaidWithinData.Name = "ux_HighestPaidWithinData";
            this.ux_HighestPaidWithinData.Size = new System.Drawing.Size(763, 323);
            this.ux_HighestPaidWithinData.TabIndex = 7;
            // 
            // ux_EndDatePicker
            // 
            this.ux_EndDatePicker.Location = new System.Drawing.Point(651, 60);
            this.ux_EndDatePicker.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.ux_EndDatePicker.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.ux_EndDatePicker.Name = "ux_EndDatePicker";
            this.ux_EndDatePicker.Size = new System.Drawing.Size(120, 22);
            this.ux_EndDatePicker.TabIndex = 6;
            this.ux_EndDatePicker.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // ux_StartDatePicker
            // 
            this.ux_StartDatePicker.Location = new System.Drawing.Point(8, 60);
            this.ux_StartDatePicker.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.ux_StartDatePicker.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.ux_StartDatePicker.Name = "ux_StartDatePicker";
            this.ux_StartDatePicker.Size = new System.Drawing.Size(120, 22);
            this.ux_StartDatePicker.TabIndex = 5;
            this.ux_StartDatePicker.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(700, 41);
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
            // ux_AverageProfitByStudioandGenre
            // 
            this.ux_AverageProfitByStudioandGenre.Controls.Add(this.ux_ASPbGButton);
            this.ux_AverageProfitByStudioandGenre.Controls.Add(this.ux_ASPbGDataGrid);
            this.ux_AverageProfitByStudioandGenre.Controls.Add(this.ux_GenrePicker);
            this.ux_AverageProfitByStudioandGenre.Controls.Add(this.label3);
            this.ux_AverageProfitByStudioandGenre.Location = new System.Drawing.Point(4, 25);
            this.ux_AverageProfitByStudioandGenre.Name = "ux_AverageProfitByStudioandGenre";
            this.ux_AverageProfitByStudioandGenre.Size = new System.Drawing.Size(776, 417);
            this.ux_AverageProfitByStudioandGenre.TabIndex = 3;
            this.ux_AverageProfitByStudioandGenre.Text = "Profit";
            this.ux_AverageProfitByStudioandGenre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Genre Id";
            // 
            // ux_dad
            // 
            this.ux_dad.Controls.Add(this.ux_APCbGButton);
            this.ux_dad.Controls.Add(this.ux_APCbGDataGrid);
            this.ux_dad.Controls.Add(this.ux_APCbGGenrePicker);
            this.ux_dad.Controls.Add(this.label1);
            this.ux_dad.Location = new System.Drawing.Point(4, 25);
            this.ux_dad.Name = "ux_dad";
            this.ux_dad.Padding = new System.Windows.Forms.Padding(3);
            this.ux_dad.Size = new System.Drawing.Size(776, 417);
            this.ux_dad.TabIndex = 7;
            this.ux_dad.Text = "Cost";
            this.ux_dad.UseVisualStyleBackColor = true;
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
            // ux_GenrePicker
            // 
            this.ux_GenrePicker.Location = new System.Drawing.Point(21, 47);
            this.ux_GenrePicker.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.ux_GenrePicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ux_GenrePicker.Name = "ux_GenrePicker";
            this.ux_GenrePicker.Size = new System.Drawing.Size(120, 22);
            this.ux_GenrePicker.TabIndex = 3;
            this.ux_GenrePicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ux_ASPbGDataGrid
            // 
            this.ux_ASPbGDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ux_ASPbGDataGrid.Location = new System.Drawing.Point(4, 75);
            this.ux_ASPbGDataGrid.Name = "ux_ASPbGDataGrid";
            this.ux_ASPbGDataGrid.Size = new System.Drawing.Size(767, 336);
            this.ux_ASPbGDataGrid.TabIndex = 4;
            // 
            // ux_ASPbGButton
            // 
            this.ux_ASPbGButton.Location = new System.Drawing.Point(179, 12);
            this.ux_ASPbGButton.Name = "ux_ASPbGButton";
            this.ux_ASPbGButton.Size = new System.Drawing.Size(410, 23);
            this.ux_ASPbGButton.TabIndex = 5;
            this.ux_ASPbGButton.Text = "Calculate Average Profit Grouped by Studio and Genre";
            this.ux_ASPbGButton.UseVisualStyleBackColor = true;
            this.ux_ASPbGButton.Click += new System.EventHandler(this.ux_ASPbGButton_Click);
            // 
            // ux_APCbGButton
            // 
            this.ux_APCbGButton.Location = new System.Drawing.Point(180, 9);
            this.ux_APCbGButton.Name = "ux_APCbGButton";
            this.ux_APCbGButton.Size = new System.Drawing.Size(410, 23);
            this.ux_APCbGButton.TabIndex = 9;
            this.ux_APCbGButton.Text = "Calculate Average Production Cost by Genre";
            this.ux_APCbGButton.UseVisualStyleBackColor = true;
            this.ux_APCbGButton.Click += new System.EventHandler(this.ux_APCbGButton_Click);
            // 
            // ux_APCbGDataGrid
            // 
            this.ux_APCbGDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ux_APCbGDataGrid.Location = new System.Drawing.Point(5, 72);
            this.ux_APCbGDataGrid.Name = "ux_APCbGDataGrid";
            this.ux_APCbGDataGrid.Size = new System.Drawing.Size(767, 336);
            this.ux_APCbGDataGrid.TabIndex = 8;
            // 
            // ux_APCbGGenrePicker
            // 
            this.ux_APCbGGenrePicker.Location = new System.Drawing.Point(22, 44);
            this.ux_APCbGGenrePicker.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.ux_APCbGGenrePicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ux_APCbGGenrePicker.Name = "ux_APCbGGenrePicker";
            this.ux_APCbGGenrePicker.Size = new System.Drawing.Size(120, 22);
            this.ux_APCbGGenrePicker.TabIndex = 7;
            this.ux_APCbGGenrePicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Genre Id";
            // 
            // uxAddUserButton
            // 
            this.uxAddUserButton.Location = new System.Drawing.Point(595, 294);
            this.uxAddUserButton.Name = "uxAddUserButton";
            this.uxAddUserButton.Size = new System.Drawing.Size(175, 43);
            this.uxAddUserButton.TabIndex = 19;
            this.uxAddUserButton.Text = "Add User";
            this.uxAddUserButton.UseVisualStyleBackColor = true;
            this.uxAddUserButton.Click += new System.EventHandler(this.uxAddUserButton_Click);
            // 
            // ux_MovieBox
            // 
            this.ux_MovieBox.FormattingEnabled = true;
            this.ux_MovieBox.Location = new System.Drawing.Point(6, 6);
            this.ux_MovieBox.Name = "ux_MovieBox";
            this.ux_MovieBox.Size = new System.Drawing.Size(419, 24);
            this.ux_MovieBox.TabIndex = 0;
            this.ux_MovieBox.SelectedIndexChanged += new System.EventHandler(this.ux_MovieBox_SelectedIndexChanged);
            // 
            // ux_MovieCompareDataGrid
            // 
            this.ux_MovieCompareDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ux_MovieCompareDataGrid.Location = new System.Drawing.Point(6, 97);
            this.ux_MovieCompareDataGrid.Name = "ux_MovieCompareDataGrid";
            this.ux_MovieCompareDataGrid.Size = new System.Drawing.Size(764, 314);
            this.ux_MovieCompareDataGrid.TabIndex = 1;
            // 
            // ux_MovieCompareButton
            // 
            this.ux_MovieCompareButton.Location = new System.Drawing.Point(597, 7);
            this.ux_MovieCompareButton.Name = "ux_MovieCompareButton";
            this.ux_MovieCompareButton.Size = new System.Drawing.Size(173, 23);
            this.ux_MovieCompareButton.TabIndex = 2;
            this.ux_MovieCompareButton.Text = "Compare";
            this.ux_MovieCompareButton.UseVisualStyleBackColor = true;
            this.ux_MovieCompareButton.Click += new System.EventHandler(this.ux_MovieCompareButton_Click);
            // 
            // ux_ReviewRefresh
            // 
            this.ux_ReviewRefresh.Location = new System.Drawing.Point(518, 32);
            this.ux_ReviewRefresh.Name = "ux_ReviewRefresh";
            this.ux_ReviewRefresh.Size = new System.Drawing.Size(164, 23);
            this.ux_ReviewRefresh.TabIndex = 31;
            this.ux_ReviewRefresh.Text = "Refresh";
            this.ux_ReviewRefresh.UseVisualStyleBackColor = true;
            this.ux_ReviewRefresh.Click += new System.EventHandler(this.ux_ReviewRefresh_Click);
            // 
            // ux_CompareRefresh
            // 
            this.ux_CompareRefresh.Location = new System.Drawing.Point(597, 36);
            this.ux_CompareRefresh.Name = "ux_CompareRefresh";
            this.ux_CompareRefresh.Size = new System.Drawing.Size(173, 23);
            this.ux_CompareRefresh.TabIndex = 3;
            this.ux_CompareRefresh.Text = "Refresh";
            this.ux_CompareRefresh.UseVisualStyleBackColor = true;
            this.ux_CompareRefresh.Click += new System.EventHandler(this.ux_CompareRefresh_Click);
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
            this.ux_GenresTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ux_GenresDataView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ux_HighestPaidWithinData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_EndDatePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_StartDatePicker)).EndInit();
            this.ux_AverageProfitByStudioandGenre.ResumeLayout(false);
            this.ux_AverageProfitByStudioandGenre.PerformLayout();
            this.ux_dad.ResumeLayout(false);
            this.ux_dad.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ux_GenrePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_ASPbGDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_APCbGDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_APCbGGenrePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_MovieCompareDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ux_TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage ux_AverageProfitByStudioandGenre;
        private System.Windows.Forms.TabPage ux_GenresTab;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.DataGridView ux_GenresDataView;
        private System.Windows.Forms.Button ux_GenrePopulateButton;
        private System.Windows.Forms.NumericUpDown ux_EndDatePicker;
        private System.Windows.Forms.NumericUpDown ux_StartDatePicker;
        private System.Windows.Forms.Button ux_CalcHighestPaidWithin;
        private System.Windows.Forms.DataGridView ux_HighestPaidWithinData;
        private System.Windows.Forms.TabPage ux_dad;
        private System.Windows.Forms.Button ux_ASPbGButton;
        private System.Windows.Forms.DataGridView ux_ASPbGDataGrid;
        private System.Windows.Forms.NumericUpDown ux_GenrePicker;
        private System.Windows.Forms.Button ux_APCbGButton;
        private System.Windows.Forms.DataGridView ux_APCbGDataGrid;
        private System.Windows.Forms.NumericUpDown ux_APCbGGenrePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxAddUserButton;
        private System.Windows.Forms.ComboBox ux_MovieBox;
        private System.Windows.Forms.Button ux_MovieCompareButton;
        private System.Windows.Forms.DataGridView ux_MovieCompareDataGrid;
        private System.Windows.Forms.Button ux_ReviewRefresh;
        private System.Windows.Forms.Button ux_CompareRefresh;
    }
}