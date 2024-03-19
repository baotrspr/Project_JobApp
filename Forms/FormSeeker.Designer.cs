namespace Project_JobApp.Forms
{
    partial class FormSeeker
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
            this.docker = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnTab = new System.Windows.Forms.Panel();
            this.ucJobFeed = new Project_JobApp.UC.UCJobFeed();
            this.ucAccount = new Project_JobApp.UC.UCAccount();
            this.ucProfile = new Project_JobApp.UC.UCProfile();
            this.ucHome = new Project_JobApp.UC.UCHome();
            this.ucAppliedJob = new Project_JobApp.UC.UCAppliedJob();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.rdbInfo = new System.Windows.Forms.RadioButton();
            this.rdbAccount = new System.Windows.Forms.RadioButton();
            this.rdbApplied = new System.Windows.Forms.RadioButton();
            this.rdbFeed = new System.Windows.Forms.RadioButton();
            this.rdbHome = new System.Windows.Forms.RadioButton();
            this.docker.SuspendLayout();
            this.pnTab.SuspendLayout();
            this.pnNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // docker
            // 
            this.docker.BackColor = System.Drawing.Color.SeaGreen;
            this.docker.Controls.Add(this.lblInfo);
            this.docker.Controls.Add(this.btnBack);
            this.docker.Controls.Add(this.btnMinimize);
            this.docker.Controls.Add(this.btnExit);
            this.docker.Dock = System.Windows.Forms.DockStyle.Top;
            this.docker.Location = new System.Drawing.Point(0, 0);
            this.docker.Name = "docker";
            this.docker.Size = new System.Drawing.Size(1000, 30);
            this.docker.TabIndex = 0;
            this.docker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.docker_MouseDown);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Location = new System.Drawing.Point(73, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(150, 30);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "UserInfo";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 30);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Đăng xuất";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinimize.Location = new System.Drawing.Point(890, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.Location = new System.Drawing.Point(940, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnTab
            // 
            this.pnTab.BackColor = System.Drawing.SystemColors.Control;
            this.pnTab.Controls.Add(this.ucJobFeed);
            this.pnTab.Controls.Add(this.ucAccount);
            this.pnTab.Controls.Add(this.ucProfile);
            this.pnTab.Controls.Add(this.ucHome);
            this.pnTab.Controls.Add(this.ucAppliedJob);
            this.pnTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTab.Location = new System.Drawing.Point(200, 30);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(800, 600);
            this.pnTab.TabIndex = 4;
            // 
            // ucJobFeed
            // 
            this.ucJobFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucJobFeed.Location = new System.Drawing.Point(0, 0);
            this.ucJobFeed.Name = "ucJobFeed";
            this.ucJobFeed.Size = new System.Drawing.Size(800, 600);
            this.ucJobFeed.TabIndex = 3;
            // 
            // ucAccount
            // 
            this.ucAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAccount.GetAccount = null;
            this.ucAccount.Location = new System.Drawing.Point(0, 0);
            this.ucAccount.Matkhau = "";
            this.ucAccount.Name = "ucAccount";
            this.ucAccount.Size = new System.Drawing.Size(800, 600);
            this.ucAccount.TabIndex = 5;
            this.ucAccount.Userid = "";
            // 
            // ucProfile
            // 
            this.ucProfile.BackColor = System.Drawing.Color.White;
            this.ucProfile.Cmnd = "";
            this.ucProfile.Diachi = "";
            this.ucProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProfile.Email = "";
            this.ucProfile.GetAccount = null;
            this.ucProfile.Ho = "";
            this.ucProfile.Location = new System.Drawing.Point(0, 0);
            this.ucProfile.Name = "ucProfile";
            this.ucProfile.Ngsinh = "17/03/2024";
            this.ucProfile.Sdt = "";
            this.ucProfile.Size = new System.Drawing.Size(800, 600);
            this.ucProfile.TabIndex = 1;
            this.ucProfile.Ten = "";
            this.ucProfile.Thongtin = "";
            this.ucProfile.Userid = "";
            // 
            // ucHome
            // 
            this.ucHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome.Location = new System.Drawing.Point(0, 0);
            this.ucHome.Name = "ucHome";
            this.ucHome.Size = new System.Drawing.Size(800, 600);
            this.ucHome.TabIndex = 4;
            // 
            // ucAppliedJob
            // 
            this.ucAppliedJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAppliedJob.Location = new System.Drawing.Point(0, 0);
            this.ucAppliedJob.Name = "ucAppliedJob";
            this.ucAppliedJob.Size = new System.Drawing.Size(800, 600);
            this.ucAppliedJob.TabIndex = 2;
            // 
            // pnNavigation
            // 
            this.pnNavigation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnNavigation.Controls.Add(this.rdbInfo);
            this.pnNavigation.Controls.Add(this.rdbAccount);
            this.pnNavigation.Controls.Add(this.rdbApplied);
            this.pnNavigation.Controls.Add(this.rdbFeed);
            this.pnNavigation.Controls.Add(this.rdbHome);
            this.pnNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNavigation.Location = new System.Drawing.Point(0, 30);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(200, 600);
            this.pnNavigation.TabIndex = 3;
            // 
            // rdbInfo
            // 
            this.rdbInfo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rdbInfo.FlatAppearance.BorderSize = 0;
            this.rdbInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rdbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInfo.Image = global::Project_JobApp.Properties.Resources.document;
            this.rdbInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbInfo.Location = new System.Drawing.Point(0, 400);
            this.rdbInfo.Name = "rdbInfo";
            this.rdbInfo.Size = new System.Drawing.Size(200, 100);
            this.rdbInfo.TabIndex = 5;
            this.rdbInfo.Text = "    Thông tin";
            this.rdbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdbInfo.UseVisualStyleBackColor = true;
            this.rdbInfo.CheckedChanged += new System.EventHandler(this.rdbInfo_CheckedChanged);
            // 
            // rdbAccount
            // 
            this.rdbAccount.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rdbAccount.FlatAppearance.BorderSize = 0;
            this.rdbAccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rdbAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAccount.Image = global::Project_JobApp.Properties.Resources.user;
            this.rdbAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbAccount.Location = new System.Drawing.Point(0, 500);
            this.rdbAccount.Name = "rdbAccount";
            this.rdbAccount.Size = new System.Drawing.Size(200, 100);
            this.rdbAccount.TabIndex = 4;
            this.rdbAccount.Text = "    Tài khoản";
            this.rdbAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdbAccount.UseVisualStyleBackColor = true;
            this.rdbAccount.CheckedChanged += new System.EventHandler(this.rdbAccount_CheckedChanged);
            // 
            // rdbApplied
            // 
            this.rdbApplied.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbApplied.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbApplied.FlatAppearance.BorderSize = 0;
            this.rdbApplied.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rdbApplied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbApplied.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbApplied.Image = global::Project_JobApp.Properties.Resources.table_list;
            this.rdbApplied.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbApplied.Location = new System.Drawing.Point(0, 200);
            this.rdbApplied.Name = "rdbApplied";
            this.rdbApplied.Size = new System.Drawing.Size(200, 100);
            this.rdbApplied.TabIndex = 3;
            this.rdbApplied.Text = "    Đã ứng tuyển";
            this.rdbApplied.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbApplied.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdbApplied.UseVisualStyleBackColor = true;
            this.rdbApplied.CheckedChanged += new System.EventHandler(this.rdbApplied_CheckedChanged);
            // 
            // rdbFeed
            // 
            this.rdbFeed.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbFeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbFeed.FlatAppearance.BorderSize = 0;
            this.rdbFeed.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rdbFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbFeed.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFeed.Image = global::Project_JobApp.Properties.Resources.rectangle_list;
            this.rdbFeed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbFeed.Location = new System.Drawing.Point(0, 100);
            this.rdbFeed.Name = "rdbFeed";
            this.rdbFeed.Size = new System.Drawing.Size(200, 100);
            this.rdbFeed.TabIndex = 2;
            this.rdbFeed.Text = "    Bài đăng";
            this.rdbFeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbFeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdbFeed.UseVisualStyleBackColor = true;
            this.rdbFeed.CheckedChanged += new System.EventHandler(this.rdbFeed_CheckedChanged);
            // 
            // rdbHome
            // 
            this.rdbHome.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbHome.FlatAppearance.BorderSize = 0;
            this.rdbHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rdbHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbHome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHome.Image = global::Project_JobApp.Properties.Resources.home;
            this.rdbHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbHome.Location = new System.Drawing.Point(0, 0);
            this.rdbHome.Name = "rdbHome";
            this.rdbHome.Size = new System.Drawing.Size(200, 100);
            this.rdbHome.TabIndex = 1;
            this.rdbHome.Text = "    Trang chủ";
            this.rdbHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdbHome.UseVisualStyleBackColor = true;
            this.rdbHome.CheckedChanged += new System.EventHandler(this.rdbHome_CheckedChanged);
            // 
            // FormSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.pnNavigation);
            this.Controls.Add(this.docker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSeeker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeeker";
            this.Load += new System.EventHandler(this.FormSeeker_Load);
            this.docker.ResumeLayout(false);
            this.pnTab.ResumeLayout(false);
            this.pnNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel docker;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnTab;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Button btnBack;
        private UC.UCHome ucHome;
        private UC.UCJobFeed ucJobFeed;
        private UC.UCAppliedJob ucAppliedJob;
        private UC.UCProfile ucProfile;
        private System.Windows.Forms.RadioButton rdbHome;
        private System.Windows.Forms.RadioButton rdbInfo;
        private System.Windows.Forms.RadioButton rdbAccount;
        private System.Windows.Forms.RadioButton rdbApplied;
        private System.Windows.Forms.RadioButton rdbFeed;
        private System.Windows.Forms.Label lblInfo;
        private UC.UCAccount ucAccount;
    }
}