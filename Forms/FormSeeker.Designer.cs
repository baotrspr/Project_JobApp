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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnTab = new System.Windows.Forms.Panel();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAppliedJobs = new System.Windows.Forms.Button();
            this.btnJobFeeds = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.docker.SuspendLayout();
            this.pnNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // docker
            // 
            this.docker.BackColor = System.Drawing.Color.SeaGreen;
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 30);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
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
            this.pnTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTab.Location = new System.Drawing.Point(200, 30);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(800, 560);
            this.pnTab.TabIndex = 4;
            // 
            // pnNavigation
            // 
            this.pnNavigation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnNavigation.Controls.Add(this.btnMyProfile);
            this.pnNavigation.Controls.Add(this.btnAccount);
            this.pnNavigation.Controls.Add(this.btnAppliedJobs);
            this.pnNavigation.Controls.Add(this.btnJobFeeds);
            this.pnNavigation.Controls.Add(this.btnHome);
            this.pnNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNavigation.Location = new System.Drawing.Point(0, 30);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(200, 600);
            this.pnNavigation.TabIndex = 3;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.Image = global::Project_JobApp.Properties.Resources.document;
            this.btnMyProfile.Location = new System.Drawing.Point(0, 400);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(200, 100);
            this.btnMyProfile.TabIndex = 0;
            this.btnMyProfile.Text = "    My Profile";
            this.btnMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Image = global::Project_JobApp.Properties.Resources.user;
            this.btnAccount.Location = new System.Drawing.Point(0, 500);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(200, 100);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "    My Account";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnAppliedJobs
            // 
            this.btnAppliedJobs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppliedJobs.FlatAppearance.BorderSize = 0;
            this.btnAppliedJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppliedJobs.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppliedJobs.Image = global::Project_JobApp.Properties.Resources.bookmark;
            this.btnAppliedJobs.Location = new System.Drawing.Point(0, 200);
            this.btnAppliedJobs.Name = "btnAppliedJobs";
            this.btnAppliedJobs.Size = new System.Drawing.Size(200, 100);
            this.btnAppliedJobs.TabIndex = 0;
            this.btnAppliedJobs.Text = "    Applied Jobs";
            this.btnAppliedJobs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppliedJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppliedJobs.UseVisualStyleBackColor = true;
            this.btnAppliedJobs.Click += new System.EventHandler(this.btnAppliedJobs_Click);
            // 
            // btnJobFeeds
            // 
            this.btnJobFeeds.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobFeeds.FlatAppearance.BorderSize = 0;
            this.btnJobFeeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobFeeds.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobFeeds.Image = global::Project_JobApp.Properties.Resources.users_alt;
            this.btnJobFeeds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobFeeds.Location = new System.Drawing.Point(0, 100);
            this.btnJobFeeds.Name = "btnJobFeeds";
            this.btnJobFeeds.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnJobFeeds.Size = new System.Drawing.Size(200, 100);
            this.btnJobFeeds.TabIndex = 0;
            this.btnJobFeeds.Text = "    Job Feeds";
            this.btnJobFeeds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobFeeds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJobFeeds.UseVisualStyleBackColor = true;
            this.btnJobFeeds.Click += new System.EventHandler(this.btnJobFeeds_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::Project_JobApp.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 100);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "    Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(658, 596);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(414, 596);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Chỉnh sửa thông tin";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // FormSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.pnNavigation);
            this.Controls.Add(this.docker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSeeker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeeker";
            this.Load += new System.EventHandler(this.FormSeeker_Load);
            this.docker.ResumeLayout(false);
            this.pnNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel docker;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnTab;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAppliedJobs;
        private System.Windows.Forms.Button btnJobFeeds;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
    }
}