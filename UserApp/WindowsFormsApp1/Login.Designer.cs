namespace WindowsFormsApp1
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
            this.UXUserName = new System.Windows.Forms.TextBox();
            this.UXPassword = new System.Windows.Forms.TextBox();
            this.Lo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UXLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UXUserName
            // 
            this.UXUserName.Location = new System.Drawing.Point(266, 148);
            this.UXUserName.Name = "UXUserName";
            this.UXUserName.Size = new System.Drawing.Size(260, 20);
            this.UXUserName.TabIndex = 0;
            // 
            // UXPassword
            // 
            this.UXPassword.Location = new System.Drawing.Point(266, 265);
            this.UXPassword.Name = "UXPassword";
            this.UXPassword.Size = new System.Drawing.Size(260, 20);
            this.UXPassword.TabIndex = 1;
            // 
            // Lo
            // 
            this.Lo.AutoSize = true;
            this.Lo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lo.Location = new System.Drawing.Point(360, 9);
            this.Lo.Name = "Lo";
            this.Lo.Size = new System.Drawing.Size(70, 25);
            this.Lo.TabIndex = 2;
            this.Lo.Text = "Login";
            this.Lo.Click += new System.EventHandler(this.Lo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // UXLoginBtn
            // 
            this.UXLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UXLoginBtn.Location = new System.Drawing.Point(360, 323);
            this.UXLoginBtn.Name = "UXLoginBtn";
            this.UXLoginBtn.Size = new System.Drawing.Size(75, 31);
            this.UXLoginBtn.TabIndex = 5;
            this.UXLoginBtn.Text = "Login";
            this.UXLoginBtn.UseVisualStyleBackColor = true;
            this.UXLoginBtn.Click += new System.EventHandler(this.UXLoginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UXLoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lo);
            this.Controls.Add(this.UXPassword);
            this.Controls.Add(this.UXUserName);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UXUserName;
        private System.Windows.Forms.TextBox UXPassword;
        private System.Windows.Forms.Label Lo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UXLoginBtn;
    }
}

