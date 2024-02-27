﻿namespace Project_JobApp.UC
{
    partial class UCSignUp
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
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.rbtHirer = new System.Windows.Forms.RadioButton();
            this.rbtJobSeeker = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lblRule = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tblpSignUp = new System.Windows.Forms.TableLayoutPanel();
            this.pnLogin.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.tblpSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogin.Controls.Add(this.lblTitle);
            this.pnLogin.Controls.Add(this.lblOr);
            this.pnLogin.Controls.Add(this.rbtHirer);
            this.pnLogin.Controls.Add(this.rbtJobSeeker);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.btnSignUp);
            this.pnLogin.Controls.Add(this.txtUsername);
            this.pnLogin.Controls.Add(this.lblUsername);
            this.pnLogin.Controls.Add(this.txtRePassword);
            this.pnLogin.Controls.Add(this.txtPassword);
            this.pnLogin.Controls.Add(this.lblRePassword);
            this.pnLogin.Controls.Add(this.lblRole);
            this.pnLogin.Controls.Add(this.lblPassword);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLogin.Location = new System.Drawing.Point(703, 288);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(274, 374);
            this.pnLogin.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(96, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 31);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Sign up";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(138, 308);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(16, 13);
            this.lblOr.TabIndex = 4;
            this.lblOr.Text = "or";
            // 
            // rbtHirer
            // 
            this.rbtHirer.AutoSize = true;
            this.rbtHirer.Location = new System.Drawing.Point(194, 222);
            this.rbtHirer.Name = "rbtHirer";
            this.rbtHirer.Size = new System.Drawing.Size(41, 17);
            this.rbtHirer.TabIndex = 3;
            this.rbtHirer.TabStop = true;
            this.rbtHirer.Text = "HR";
            this.rbtHirer.UseVisualStyleBackColor = true;
            // 
            // rbtJobSeeker
            // 
            this.rbtJobSeeker.AutoSize = true;
            this.rbtJobSeeker.Location = new System.Drawing.Point(35, 222);
            this.rbtJobSeeker.Name = "rbtJobSeeker";
            this.rbtJobSeeker.Size = new System.Drawing.Size(76, 17);
            this.rbtJobSeeker.TabIndex = 3;
            this.rbtJobSeeker.TabStop = true;
            this.rbtJobSeeker.Text = "JobSeeker";
            this.rbtJobSeeker.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(35, 334);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(35, 254);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(230, 40);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign up now";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(130, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(135, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(32, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(43, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User ID";
            // 
            // txtRePassword
            // 
            this.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRePassword.Location = new System.Drawing.Point(130, 156);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(135, 20);
            this.txtRePassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(130, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(135, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(32, 159);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(97, 13);
            this.lblRePassword.TabIndex = 0;
            this.lblRePassword.Text = "Re-enter Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(32, 193);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(47, 13);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "You are:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(32, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnInfo.Controls.Add(this.lblRule);
            this.pnInfo.Controls.Add(this.lblName);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInfo.Location = new System.Drawing.Point(423, 288);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(274, 374);
            this.pnInfo.TabIndex = 4;
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Font = new System.Drawing.Font("SVN-Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRule.Location = new System.Drawing.Point(50, 96);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(181, 19);
            this.lblRule.TabIndex = 0;
            this.lblRule.Text = "Job Seeking - Hiring Platform";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(63, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(161, 34);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "KeenOnJob";
            // 
            // tblpSignUp
            // 
            this.tblpSignUp.BackColor = System.Drawing.Color.Transparent;
            this.tblpSignUp.ColumnCount = 4;
            this.tblpSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpSignUp.Controls.Add(this.pnLogin, 2, 1);
            this.tblpSignUp.Controls.Add(this.pnInfo, 1, 1);
            this.tblpSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpSignUp.Location = new System.Drawing.Point(0, 0);
            this.tblpSignUp.Name = "tblpSignUp";
            this.tblpSignUp.RowCount = 3;
            this.tblpSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblpSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpSignUp.Size = new System.Drawing.Size(1400, 950);
            this.tblpSignUp.TabIndex = 6;
            // 
            // SignUpUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblpSignUp);
            this.Name = "SignUpUC";
            this.Size = new System.Drawing.Size(1400, 950);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.tblpSignUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.RadioButton rbtHirer;
        private System.Windows.Forms.RadioButton rbtJobSeeker;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.TableLayoutPanel tblpSignUp;
    }
}
