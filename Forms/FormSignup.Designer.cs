namespace Project_JobApp.Forms
{
    partial class FormSignup
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.rdbCompany = new System.Windows.Forms.RadioButton();
            this.rdbJobSeeker = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
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
            this.pnInfo.Size = new System.Drawing.Size(400, 500);
            this.pnInfo.TabIndex = 5;
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Font = new System.Drawing.Font("SVN-Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRule.Location = new System.Drawing.Point(100, 98);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(212, 22);
            this.lblRule.TabIndex = 0;
            this.lblRule.Text = "Job Seeking - Hiring Platform";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(102, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(209, 45);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "KeenOnJob";
            // 
            // pnLogin
            // 
            this.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogin.Controls.Add(this.btnExit);
            this.pnLogin.Controls.Add(this.lblTitle);
            this.pnLogin.Controls.Add(this.lblOr);
            this.pnLogin.Controls.Add(this.rdbCompany);
            this.pnLogin.Controls.Add(this.rdbJobSeeker);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.btnSignUp);
            this.pnLogin.Controls.Add(this.txtUsername);
            this.pnLogin.Controls.Add(this.lblUsername);
            this.pnLogin.Controls.Add(this.txtRePassword);
            this.pnLogin.Controls.Add(this.txtPassword);
            this.pnLogin.Controls.Add(this.lblRePassword);
            this.pnLogin.Controls.Add(this.lblRole);
            this.pnLogin.Controls.Add(this.lblPassword);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnLogin.Location = new System.Drawing.Point(400, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(400, 500);
            this.pnLogin.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(350, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(156, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 31);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Đăng kí";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.Location = new System.Drawing.Point(187, 390);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(34, 20);
            this.lblOr.TabIndex = 4;
            this.lblOr.Text = "hay";
            // 
            // rdbCompany
            // 
            this.rdbCompany.AutoSize = true;
            this.rdbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCompany.Location = new System.Drawing.Point(266, 260);
            this.rdbCompany.Name = "rdbCompany";
            this.rdbCompany.Size = new System.Drawing.Size(83, 20);
            this.rdbCompany.TabIndex = 3;
            this.rdbCompany.TabStop = true;
            this.rdbCompany.Text = "Company";
            this.rdbCompany.UseVisualStyleBackColor = true;
            // 
            // rdbJobSeeker
            // 
            this.rdbJobSeeker.AutoSize = true;
            this.rdbJobSeeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbJobSeeker.Location = new System.Drawing.Point(51, 259);
            this.rdbJobSeeker.Name = "rdbJobSeeker";
            this.rdbJobSeeker.Size = new System.Drawing.Size(92, 20);
            this.rdbJobSeeker.TabIndex = 3;
            this.rdbJobSeeker.TabStop = true;
            this.rdbJobSeeker.Text = "JobSeeker";
            this.rdbJobSeeker.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(74, 416);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập tài khoản";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(49, 329);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(300, 50);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Đăng kí";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(203, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(135, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(49, 99);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(52, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User ID";
            // 
            // txtRePassword
            // 
            this.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Location = new System.Drawing.Point(203, 186);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '●';
            this.txtRePassword.Size = new System.Drawing.Size(135, 22);
            this.txtRePassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(203, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(135, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePassword.Location = new System.Drawing.Point(49, 188);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(122, 16);
            this.lblRePassword.TabIndex = 0;
            this.lblRePassword.Text = "Re-enter Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(48, 230);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 16);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Bạn là:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(49, 143);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignup";
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
        private System.Windows.Forms.RadioButton rdbCompany;
        private System.Windows.Forms.RadioButton rdbJobSeeker;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnExit;
    }
}