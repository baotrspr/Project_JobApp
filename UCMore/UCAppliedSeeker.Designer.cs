namespace Project_JobApp.UCMore
{
    partial class UCAppliedSeeker
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblSeekerID = new System.Windows.Forms.Label();
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblSeekerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Aqua;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 3);
            this.panel6.TabIndex = 15;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(383, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(122, 18);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Thời gian";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJob
            // 
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(254, 10);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(128, 18);
            this.lblJob.TabIndex = 7;
            this.lblJob.Text = "TênCV";
            this.lblJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeekerID
            // 
            this.lblSeekerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeekerID.Location = new System.Drawing.Point(3, 10);
            this.lblSeekerID.Name = "lblSeekerID";
            this.lblSeekerID.Size = new System.Drawing.Size(93, 18);
            this.lblSeekerID.TabIndex = 8;
            this.lblSeekerID.Text = "Mã Seeker";
            this.lblSeekerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxStatus
            // 
            this.pbxStatus.Location = new System.Drawing.Point(601, 3);
            this.pbxStatus.Name = "pbxStatus";
            this.pbxStatus.Size = new System.Drawing.Size(32, 32);
            this.pbxStatus.TabIndex = 17;
            this.pbxStatus.TabStop = false;
            // 
            // btnDecline
            // 
            this.btnDecline.Image = global::Project_JobApp.Properties.Resources.rejected;
            this.btnDecline.Location = new System.Drawing.Point(732, 3);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(50, 32);
            this.btnDecline.TabIndex = 16;
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.Image = global::Project_JobApp.Properties.Resources.accepted;
            this.btnAccept.Location = new System.Drawing.Point(662, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(50, 32);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblSeekerName
            // 
            this.lblSeekerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeekerName.Location = new System.Drawing.Point(105, 10);
            this.lblSeekerName.Name = "lblSeekerName";
            this.lblSeekerName.Size = new System.Drawing.Size(135, 18);
            this.lblSeekerName.TabIndex = 8;
            this.lblSeekerName.Text = "Tên Seeker";
            this.lblSeekerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCAppliedSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbxStatus);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblSeekerName);
            this.Controls.Add(this.lblSeekerID);
            this.Name = "UCAppliedSeeker";
            this.Size = new System.Drawing.Size(800, 40);
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblSeekerID;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.PictureBox pbxStatus;
        private System.Windows.Forms.Label lblSeekerName;
    }
}
