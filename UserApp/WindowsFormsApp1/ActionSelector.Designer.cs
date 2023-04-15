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
            this.UXPersonalReviews = new System.Windows.Forms.ComboBox();
            this.uxMovieName = new System.Windows.Forms.TextBox();
            this.uxRatingNumber = new System.Windows.Forms.NumericUpDown();
            this.UXRatingLabel = new System.Windows.Forms.Label();
            this.UXComments = new System.Windows.Forms.TextBox();
            this.UXAddBtn = new System.Windows.Forms.Button();
            this.UXUpdateBtn = new System.Windows.Forms.Button();
            this.UXCommentsLabel = new System.Windows.Forms.Label();
            this.UxDeleteButton = new System.Windows.Forms.Button();
            this.UXTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxRatingNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // UXTabControl
            // 
            this.UXTabControl.Controls.Add(this.tabPage1);
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
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // uxMovieName
            // 
            this.uxMovieName.Location = new System.Drawing.Point(7, 48);
            this.uxMovieName.Name = "uxMovieName";
            this.uxMovieName.Size = new System.Drawing.Size(753, 22);
            this.uxMovieName.TabIndex = 1;
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
            // UXRatingLabel
            // 
            this.UXRatingLabel.AutoSize = true;
            this.UXRatingLabel.Location = new System.Drawing.Point(7, 111);
            this.UXRatingLabel.Name = "UXRatingLabel";
            this.UXRatingLabel.Size = new System.Drawing.Size(56, 16);
            this.UXRatingLabel.TabIndex = 3;
            this.UXRatingLabel.Text = "Rating:";
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
    }
}