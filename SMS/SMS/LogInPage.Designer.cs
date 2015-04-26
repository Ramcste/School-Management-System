namespace SMS
{
    partial class LogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            this.btnLogPageExit = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.randomPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.randTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.randomPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogPageExit
            // 
            this.btnLogPageExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogPageExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogPageExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogPageExit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogPageExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogPageExit.Location = new System.Drawing.Point(162, 367);
            this.btnLogPageExit.Name = "btnLogPageExit";
            this.btnLogPageExit.Size = new System.Drawing.Size(70, 35);
            this.btnLogPageExit.TabIndex = 10;
            this.btnLogPageExit.Text = "Exit";
            this.btnLogPageExit.UseVisualStyleBackColor = false;
            this.btnLogPageExit.Click += new System.EventHandler(this.btnLogPageExit_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(104, 249);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(170, 25);
            this.passwordBox.TabIndex = 12;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.Location = new System.Drawing.Point(74, 367);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(70, 35);
            this.btnLogIn.TabIndex = 9;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // userNameBox
            // 
            this.userNameBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameBox.Location = new System.Drawing.Point(104, 215);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(170, 25);
            this.userNameBox.TabIndex = 11;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Firebrick;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Location = new System.Drawing.Point(722, 625);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(72, 25);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // randomPicBox
            // 
            this.randomPicBox.BackColor = System.Drawing.Color.Transparent;
            this.randomPicBox.Location = new System.Drawing.Point(104, 297);
            this.randomPicBox.Name = "randomPicBox";
            this.randomPicBox.Size = new System.Drawing.Size(62, 28);
            this.randomPicBox.TabIndex = 15;
            this.randomPicBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Captcha:";
            // 
            // randTxt
            // 
            this.randTxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randTxt.Location = new System.Drawing.Point(174, 297);
            this.randTxt.Multiline = true;
            this.randTxt.Name = "randTxt";
            this.randTxt.Size = new System.Drawing.Size(100, 28);
            this.randTxt.TabIndex = 17;
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.randTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomPicBox);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnLogPageExit);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.userNameBox);
            this.Name = "LogInPage";
            this.Size = new System.Drawing.Size(823, 671);
            ((System.ComponentModel.ISupportInitialize)(this.randomPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogPageExit;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox randomPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox randTxt;

    }
}
