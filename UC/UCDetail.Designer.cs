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
            this.pnDocker = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.Label();
            this.txtField = new System.Windows.Forms.Label();
            this.txtID_1 = new System.Windows.Forms.Label();
            this.txtUser_1 = new System.Windows.Forms.Label();
            this.txtDate_1 = new System.Windows.Forms.Label();
            this.txtContent_1 = new System.Windows.Forms.Label();
            this.txtSalary_1 = new System.Windows.Forms.Label();
            this.txtField_1 = new System.Windows.Forms.Label();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.pnDocker.SuspendLayout();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDocker
            // 
            this.pnDocker.Controls.Add(this.btnExit);
            this.pnDocker.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDocker.Location = new System.Drawing.Point(0, 0);
            this.pnDocker.Name = "pnDocker";
            this.pnDocker.Size = new System.Drawing.Size(800, 30);
            this.pnDocker.TabIndex = 0;
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.pbxPhoto);
            this.pnInfo.Controls.Add(this.txtField_1);
            this.pnInfo.Controls.Add(this.txtField);
            this.pnInfo.Controls.Add(this.txtSalary_1);
            this.pnInfo.Controls.Add(this.txtContent_1);
            this.pnInfo.Controls.Add(this.txtSalary);
            this.pnInfo.Controls.Add(this.txtDate_1);
            this.pnInfo.Controls.Add(this.txtContent);
            this.pnInfo.Controls.Add(this.txtUser_1);
            this.pnInfo.Controls.Add(this.txtDate);
            this.pnInfo.Controls.Add(this.txtID_1);
            this.pnInfo.Controls.Add(this.txtUser);
            this.pnInfo.Controls.Add(this.txtID);
            this.pnInfo.Controls.Add(this.txtTitle);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInfo.Location = new System.Drawing.Point(0, 30);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(800, 520);
            this.pnInfo.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Firebrick;
            this.btnExit.Location = new System.Drawing.Point(725, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(330, 15);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(68, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Tiêu đề";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(28, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(55, 13);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "ID bài viết";
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Location = new System.Drawing.Point(28, 110);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(63, 13);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "Người đăng";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(28, 148);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(60, 13);
            this.txtDate.TabIndex = 2;
            this.txtDate.Text = "Ngày đăng";
            // 
            // txtContent
            // 
            this.txtContent.AutoSize = true;
            this.txtContent.Location = new System.Drawing.Point(28, 185);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(50, 13);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "Nội dung";
            // 
            // txtSalary
            // 
            this.txtSalary.AutoSize = true;
            this.txtSalary.Location = new System.Drawing.Point(28, 441);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(57, 13);
            this.txtSalary.TabIndex = 3;
            this.txtSalary.Text = "Mức lương";
            // 
            // txtField
            // 
            this.txtField.AutoSize = true;
            this.txtField.Location = new System.Drawing.Point(28, 475);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(51, 13);
            this.txtField.TabIndex = 3;
            this.txtField.Text = "Lĩnh vực";
            // 
            // txtID_1
            // 
            this.txtID_1.AutoSize = true;
            this.txtID_1.Location = new System.Drawing.Point(120, 63);
            this.txtID_1.Name = "txtID_1";
            this.txtID_1.Size = new System.Drawing.Size(55, 13);
            this.txtID_1.TabIndex = 1;
            this.txtID_1.Text = "ID bài viết";
            // 
            // txtUser_1
            // 
            this.txtUser_1.AutoSize = true;
            this.txtUser_1.Location = new System.Drawing.Point(120, 110);
            this.txtUser_1.Name = "txtUser_1";
            this.txtUser_1.Size = new System.Drawing.Size(63, 13);
            this.txtUser_1.TabIndex = 2;
            this.txtUser_1.Text = "Người đăng";
            // 
            // txtDate_1
            // 
            this.txtDate_1.AutoSize = true;
            this.txtDate_1.Location = new System.Drawing.Point(120, 148);
            this.txtDate_1.Name = "txtDate_1";
            this.txtDate_1.Size = new System.Drawing.Size(60, 13);
            this.txtDate_1.TabIndex = 2;
            this.txtDate_1.Text = "Ngày đăng";
            // 
            // txtContent_1
            // 
            this.txtContent_1.AutoSize = true;
            this.txtContent_1.Location = new System.Drawing.Point(120, 185);
            this.txtContent_1.Name = "txtContent_1";
            this.txtContent_1.Size = new System.Drawing.Size(50, 13);
            this.txtContent_1.TabIndex = 3;
            this.txtContent_1.Text = "Nội dung";
            // 
            // txtSalary_1
            // 
            this.txtSalary_1.AutoSize = true;
            this.txtSalary_1.Location = new System.Drawing.Point(120, 441);
            this.txtSalary_1.Name = "txtSalary_1";
            this.txtSalary_1.Size = new System.Drawing.Size(57, 13);
            this.txtSalary_1.TabIndex = 3;
            this.txtSalary_1.Text = "Mức lương";
            // 
            // txtField_1
            // 
            this.txtField_1.AutoSize = true;
            this.txtField_1.Location = new System.Drawing.Point(120, 475);
            this.txtField_1.Name = "txtField_1";
            this.txtField_1.Size = new System.Drawing.Size(51, 13);
            this.txtField_1.TabIndex = 3;
            this.txtField_1.Text = "Lĩnh vực";
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(523, 65);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(247, 192);
            this.pbxPhoto.TabIndex = 4;
            this.pbxPhoto.TabStop = false;
            // 
            // UCDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.pnDocker);
            this.Name = "UCDetail";
            this.Size = new System.Drawing.Size(800, 550);
            this.pnDocker.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDocker;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtContent;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.Label txtSalary;
        private System.Windows.Forms.Label txtField;
        private System.Windows.Forms.Label txtField_1;
        private System.Windows.Forms.Label txtSalary_1;
        private System.Windows.Forms.Label txtContent_1;
        private System.Windows.Forms.Label txtDate_1;
        private System.Windows.Forms.Label txtUser_1;
        private System.Windows.Forms.Label txtID_1;
    }
}
