namespace Project_JobApp.UC
{
    partial class UCDetail
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
            this.pnInfo = new System.Windows.Forms.Panel();
            this.pnJob = new System.Windows.Forms.Panel();
            this.lblJobDetail = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.pnFeedInfo = new System.Windows.Forms.Panel();
            this.btnShowJob = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblID_1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGenre_1 = new System.Windows.Forms.Label();
            this.lblContent_1 = new System.Windows.Forms.Label();
            this.lblUser_1 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblDate_1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnInfo.SuspendLayout();
            this.pnJob.SuspendLayout();
            this.pnFeedInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.pnJob);
            this.pnInfo.Controls.Add(this.pnFeedInfo);
            this.pnInfo.Controls.Add(this.lblTitle);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInfo.Location = new System.Drawing.Point(0, 0);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(800, 550);
            this.pnInfo.TabIndex = 1;
            // 
            // pnJob
            // 
            this.pnJob.Controls.Add(this.lblJobDetail);
            this.pnJob.Controls.Add(this.btnApply);
            this.pnJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnJob.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnJob.Location = new System.Drawing.Point(0, 319);
            this.pnJob.Name = "pnJob";
            this.pnJob.Size = new System.Drawing.Size(800, 231);
            this.pnJob.TabIndex = 5;
            // 
            // lblJobDetail
            // 
            this.lblJobDetail.AutoSize = true;
            this.lblJobDetail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDetail.Location = new System.Drawing.Point(30, 26);
            this.lblJobDetail.Name = "lblJobDetail";
            this.lblJobDetail.Size = new System.Drawing.Size(90, 23);
            this.lblJobDetail.TabIndex = 5;
            this.lblJobDetail.Text = "JobDetail";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.SeaGreen;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(651, 145);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(146, 53);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Ứng tuyển";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pnFeedInfo
            // 
            this.pnFeedInfo.Controls.Add(this.btnShowJob);
            this.pnFeedInfo.Controls.Add(this.lblID);
            this.pnFeedInfo.Controls.Add(this.lblUser);
            this.pnFeedInfo.Controls.Add(this.lblID_1);
            this.pnFeedInfo.Controls.Add(this.lblDate);
            this.pnFeedInfo.Controls.Add(this.lblGenre_1);
            this.pnFeedInfo.Controls.Add(this.lblContent_1);
            this.pnFeedInfo.Controls.Add(this.lblUser_1);
            this.pnFeedInfo.Controls.Add(this.lblGenre);
            this.pnFeedInfo.Controls.Add(this.lblContent);
            this.pnFeedInfo.Controls.Add(this.lblDate_1);
            this.pnFeedInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFeedInfo.Location = new System.Drawing.Point(0, 50);
            this.pnFeedInfo.Name = "pnFeedInfo";
            this.pnFeedInfo.Size = new System.Drawing.Size(800, 269);
            this.pnFeedInfo.TabIndex = 4;
            // 
            // btnShowJob
            // 
            this.btnShowJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowJob.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowJob.Location = new System.Drawing.Point(651, 223);
            this.btnShowJob.Name = "btnShowJob";
            this.btnShowJob.Size = new System.Drawing.Size(146, 46);
            this.btnShowJob.TabIndex = 4;
            this.btnShowJob.Text = "Thông tin công việc";
            this.btnShowJob.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(31, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(102, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID bài viết";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(31, 72);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(116, 24);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Người đăng";
            // 
            // lblID_1
            // 
            this.lblID_1.AutoSize = true;
            this.lblID_1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_1.Location = new System.Drawing.Point(203, 10);
            this.lblID_1.Name = "lblID_1";
            this.lblID_1.Size = new System.Drawing.Size(97, 23);
            this.lblID_1.TabIndex = 1;
            this.lblID_1.Text = "ID bài viết";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(31, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(107, 24);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Ngày đăng";
            // 
            // lblGenre_1
            // 
            this.lblGenre_1.AutoSize = true;
            this.lblGenre_1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre_1.Location = new System.Drawing.Point(203, 42);
            this.lblGenre_1.Name = "lblGenre_1";
            this.lblGenre_1.Size = new System.Drawing.Size(78, 23);
            this.lblGenre_1.TabIndex = 3;
            this.lblGenre_1.Text = "Loại bài";
            // 
            // lblContent_1
            // 
            this.lblContent_1.AutoSize = true;
            this.lblContent_1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent_1.Location = new System.Drawing.Point(203, 147);
            this.lblContent_1.Name = "lblContent_1";
            this.lblContent_1.Size = new System.Drawing.Size(88, 23);
            this.lblContent_1.TabIndex = 3;
            this.lblContent_1.Text = "Nội dung";
            // 
            // lblUser_1
            // 
            this.lblUser_1.AutoSize = true;
            this.lblUser_1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser_1.Location = new System.Drawing.Point(203, 72);
            this.lblUser_1.Name = "lblUser_1";
            this.lblUser_1.Size = new System.Drawing.Size(108, 23);
            this.lblUser_1.TabIndex = 2;
            this.lblUser_1.Text = "Người đăng";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(31, 42);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(133, 24);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Loại bài đăng";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(31, 147);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(90, 24);
            this.lblContent.TabIndex = 3;
            this.lblContent.Text = "Nội dung";
            // 
            // lblDate_1
            // 
            this.lblDate_1.AutoSize = true;
            this.lblDate_1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_1.Location = new System.Drawing.Point(203, 110);
            this.lblDate_1.Name = "lblDate_1";
            this.lblDate_1.Size = new System.Drawing.Size(98, 23);
            this.lblDate_1.TabIndex = 2;
            this.lblDate_1.Text = "Ngày đăng";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tiêu đề";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnInfo);
            this.Name = "UCDetail";
            this.Size = new System.Drawing.Size(800, 550);
            this.pnInfo.ResumeLayout(false);
            this.pnJob.ResumeLayout(false);
            this.pnJob.PerformLayout();
            this.pnFeedInfo.ResumeLayout(false);
            this.pnFeedInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblContent_1;
        private System.Windows.Forms.Label lblDate_1;
        private System.Windows.Forms.Label lblUser_1;
        private System.Windows.Forms.Label lblID_1;
        private System.Windows.Forms.Panel pnJob;
        private System.Windows.Forms.Panel pnFeedInfo;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnShowJob;
        private System.Windows.Forms.Label lblGenre_1;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblJobDetail;
    }
}
