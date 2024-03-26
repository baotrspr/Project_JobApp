namespace Project_JobApp.Forms
{
    partial class FormHirer
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnPostedJobs = new System.Windows.Forms.Button();
            this.btnJobFeeds = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.docker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.docker.Name = "docker";
            this.docker.Size = new System.Drawing.Size(1333, 37);
            this.docker.TabIndex = 1;
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
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 37);
            this.btnBack.TabIndex = 4;
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
            this.btnMinimize.Location = new System.Drawing.Point(1186, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(67, 37);
            this.btnMinimize.TabIndex = 3;
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
            this.btnExit.Location = new System.Drawing.Point(1253, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnTab
            // 
            this.pnTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTab.Location = new System.Drawing.Point(267, 37);
            this.pnTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(1066, 689);
            this.pnTab.TabIndex = 6;
            this.pnTab.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTab_Paint);
            // 
            // pnNavigation
            // 
            this.pnNavigation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnNavigation.Controls.Add(this.btnList);
            this.pnNavigation.Controls.Add(this.btnMyProfile);
            this.pnNavigation.Controls.Add(this.btnAccount);
            this.pnNavigation.Controls.Add(this.btnPostedJobs);
            this.pnNavigation.Controls.Add(this.btnJobFeeds);
            this.pnNavigation.Controls.Add(this.btnHome);
            this.pnNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNavigation.Location = new System.Drawing.Point(0, 37);
            this.pnNavigation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(267, 738);
            this.pnNavigation.TabIndex = 5;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Image = global::Project_JobApp.Properties.Resources.bookmark;
            this.btnList.Location = new System.Drawing.Point(0, 369);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(267, 123);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "    Applicants List";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMyProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.Image = global::Project_JobApp.Properties.Resources.document;
            this.btnMyProfile.Location = new System.Drawing.Point(0, 492);
            this.btnMyProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(267, 123);
            this.btnMyProfile.TabIndex = 0;
            this.btnMyProfile.Text = "    Profile";
            this.btnMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyProfile.UseVisualStyleBackColor = false;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Image = global::Project_JobApp.Properties.Resources.user;
            this.btnAccount.Location = new System.Drawing.Point(0, 615);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(267, 123);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "    My Account";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnPostedJobs
            // 
            this.btnPostedJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPostedJobs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostedJobs.FlatAppearance.BorderSize = 0;
            this.btnPostedJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostedJobs.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostedJobs.Image = global::Project_JobApp.Properties.Resources.bookmark;
            this.btnPostedJobs.Location = new System.Drawing.Point(0, 246);
            this.btnPostedJobs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPostedJobs.Name = "btnPostedJobs";
            this.btnPostedJobs.Size = new System.Drawing.Size(267, 123);
            this.btnPostedJobs.TabIndex = 0;
            this.btnPostedJobs.Text = "    Posted Jobs";
            this.btnPostedJobs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostedJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPostedJobs.UseVisualStyleBackColor = false;
            this.btnPostedJobs.Click += new System.EventHandler(this.btnPostedJobs_Click);
            // 
            // btnJobFeeds
            // 
            this.btnJobFeeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnJobFeeds.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobFeeds.FlatAppearance.BorderSize = 0;
            this.btnJobFeeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobFeeds.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobFeeds.Image = global::Project_JobApp.Properties.Resources.users_alt;
            this.btnJobFeeds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobFeeds.Location = new System.Drawing.Point(0, 123);
            this.btnJobFeeds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJobFeeds.Name = "btnJobFeeds";
            this.btnJobFeeds.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnJobFeeds.Size = new System.Drawing.Size(267, 123);
            this.btnJobFeeds.TabIndex = 0;
            this.btnJobFeeds.Text = "    Job Feeds";
            this.btnJobFeeds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobFeeds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJobFeeds.UseVisualStyleBackColor = false;
            this.btnJobFeeds.Click += new System.EventHandler(this.btnJobFeeds_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::Project_JobApp.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(267, 123);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "    Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(497, 734);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(217, 28);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Chỉnh sửa thông tin";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(829, 734);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormHirer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 775);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnNavigation);
            this.Controls.Add(this.docker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHirer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHirer";
            this.Load += new System.EventHandler(this.FormHirer_Load);
            this.docker.ResumeLayout(false);
            this.pnNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel docker;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnTab;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnPostedJobs;
        private System.Windows.Forms.Button btnJobFeeds;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
    }
}