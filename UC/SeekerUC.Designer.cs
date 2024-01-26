namespace Project_JobApp.UC
{
    partial class SeekerUC
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
            this.pnDocker = new System.Windows.Forms.Panel();
            this.lblDockerInfo = new System.Windows.Forms.Label();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAppliedJobs = new System.Windows.Forms.Button();
            this.btnJobFeeds = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnDocker.SuspendLayout();
            this.pnNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDocker
            // 
            this.pnDocker.BackColor = System.Drawing.Color.DarkCyan;
            this.pnDocker.Controls.Add(this.lblDockerInfo);
            this.pnDocker.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDocker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDocker.Location = new System.Drawing.Point(0, 0);
            this.pnDocker.Name = "pnDocker";
            this.pnDocker.Size = new System.Drawing.Size(800, 50);
            this.pnDocker.TabIndex = 0;
            // 
            // lblDockerInfo
            // 
            this.lblDockerInfo.AutoSize = true;
            this.lblDockerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDockerInfo.ForeColor = System.Drawing.Color.White;
            this.lblDockerInfo.Location = new System.Drawing.Point(16, 13);
            this.lblDockerInfo.Name = "lblDockerInfo";
            this.lblDockerInfo.Size = new System.Drawing.Size(40, 24);
            this.lblDockerInfo.TabIndex = 0;
            this.lblDockerInfo.Text = "Info";
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
            this.pnNavigation.Location = new System.Drawing.Point(0, 50);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(150, 550);
            this.pnNavigation.TabIndex = 1;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.Image = global::Project_JobApp.Properties.Resources.document;
            this.btnMyProfile.Location = new System.Drawing.Point(0, 450);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(150, 50);
            this.btnMyProfile.TabIndex = 0;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyProfile.UseVisualStyleBackColor = true;
            // 
            // btnAccount
            // 
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Image = global::Project_JobApp.Properties.Resources.user;
            this.btnAccount.Location = new System.Drawing.Point(0, 500);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(150, 50);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "My Account";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnAppliedJobs
            // 
            this.btnAppliedJobs.FlatAppearance.BorderSize = 0;
            this.btnAppliedJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppliedJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppliedJobs.Location = new System.Drawing.Point(0, 100);
            this.btnAppliedJobs.Name = "btnAppliedJobs";
            this.btnAppliedJobs.Size = new System.Drawing.Size(150, 50);
            this.btnAppliedJobs.TabIndex = 0;
            this.btnAppliedJobs.Text = "Applied Jobs";
            this.btnAppliedJobs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppliedJobs.UseVisualStyleBackColor = true;
            // 
            // btnJobFeeds
            // 
            this.btnJobFeeds.FlatAppearance.BorderSize = 0;
            this.btnJobFeeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobFeeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobFeeds.Image = global::Project_JobApp.Properties.Resources.users_alt;
            this.btnJobFeeds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobFeeds.Location = new System.Drawing.Point(0, 50);
            this.btnJobFeeds.Name = "btnJobFeeds";
            this.btnJobFeeds.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnJobFeeds.Size = new System.Drawing.Size(150, 50);
            this.btnJobFeeds.TabIndex = 0;
            this.btnJobFeeds.Text = "Job Feeds";
            this.btnJobFeeds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobFeeds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJobFeeds.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::Project_JobApp.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(150, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // SeekerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnNavigation);
            this.Controls.Add(this.pnDocker);
            this.Name = "SeekerUC";
            this.Size = new System.Drawing.Size(800, 600);
            this.pnDocker.ResumeLayout(false);
            this.pnDocker.PerformLayout();
            this.pnNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDocker;
        private System.Windows.Forms.Label lblDockerInfo;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAppliedJobs;
        private System.Windows.Forms.Button btnJobFeeds;
        private System.Windows.Forms.Button btnMyProfile;
    }
}
