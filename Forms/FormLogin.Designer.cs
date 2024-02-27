namespace Project_JobApp.Forms
{
    partial class FormLogin
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
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lblRule = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.rbtHirer = new System.Windows.Forms.RadioButton();
            this.rbtJobSeeker = new System.Windows.Forms.RadioButton();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnInfo.SuspendLayout();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnInfo.Controls.Add(this.lblRule);
            this.pnInfo.Controls.Add(this.lblName);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnInfo.Location = new System.Drawing.Point(0, 0);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(270, 400);
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
            // pnLogin
            // 
            this.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogin.Controls.Add(this.lblTitle);
            this.pnLogin.Controls.Add(this.lblOr);
            this.pnLogin.Controls.Add(this.rbtHirer);
            this.pnLogin.Controls.Add(this.rbtJobSeeker);
            this.pnLogin.Controls.Add(this.btnSignUp);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.txtUsername);
            this.pnLogin.Controls.Add(this.lblUsername);
            this.pnLogin.Controls.Add(this.txtPassword);
            this.pnLogin.Controls.Add(this.lblRole);
            this.pnLogin.Controls.Add(this.lblPassword);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnLogin.Location = new System.Drawing.Point(270, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(270, 400);
            this.pnLogin.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(59, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 31);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Đăng nhập";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(120, 284);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(24, 13);
            this.lblOr.TabIndex = 4;
            this.lblOr.Text = "hay";
            // 
            // rbtHirer
            // 
            this.rbtHirer.AutoSize = true;
            this.rbtHirer.Location = new System.Drawing.Point(173, 176);
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
            this.rbtJobSeeker.Location = new System.Drawing.Point(19, 176);
            this.rbtJobSeeker.Name = "rbtJobSeeker";
            this.rbtJobSeeker.Size = new System.Drawing.Size(76, 17);
            this.rbtJobSeeker.TabIndex = 3;
            this.rbtJobSeeker.TabStop = true;
            this.rbtJobSeeker.Text = "JobSeeker";
            this.rbtJobSeeker.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSignUp.Location = new System.Drawing.Point(19, 315);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(230, 30);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Tạo một tài khoản mới";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(19, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(114, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(135, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(43, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User ID";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(114, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(135, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(16, 147);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(40, 13);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Bạn là:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 400);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.RadioButton rbtHirer;
        private System.Windows.Forms.RadioButton rbtJobSeeker;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
    }
}