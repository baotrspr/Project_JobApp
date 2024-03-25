namespace Project_JobApp.UC
{
    partial class UCThumbnail
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDate_1 = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblOwner_1 = new System.Windows.Forms.Label();
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tiêu đề";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 59);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 19);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Ngày đăng";
            // 
            // lblDate_1
            // 
            this.lblDate_1.AutoSize = true;
            this.lblDate_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_1.Location = new System.Drawing.Point(87, 59);
            this.lblDate_1.Name = "lblDate_1";
            this.lblDate_1.Size = new System.Drawing.Size(75, 19);
            this.lblDate_1.TabIndex = 1;
            this.lblDate_1.Text = "Ngày đăng";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(3, 101);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(81, 19);
            this.lblOwner.TabIndex = 1;
            this.lblOwner.Text = "Người đăng";
            // 
            // lblOwner_1
            // 
            this.lblOwner_1.AutoSize = true;
            this.lblOwner_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner_1.Location = new System.Drawing.Point(87, 101);
            this.lblOwner_1.Name = "lblOwner_1";
            this.lblOwner_1.Size = new System.Drawing.Size(81, 19);
            this.lblOwner_1.TabIndex = 1;
            this.lblOwner_1.Text = "Người đăng";
            // 
            // pbxStatus
            // 
            this.pbxStatus.Location = new System.Drawing.Point(214, 53);
            this.pbxStatus.Name = "pbxStatus";
            this.pbxStatus.Size = new System.Drawing.Size(50, 50);
            this.pbxStatus.TabIndex = 2;
            this.pbxStatus.TabStop = false;
            // 
            // UCThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbxStatus);
            this.Controls.Add(this.lblOwner_1);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblDate_1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCThumbnail";
            this.Size = new System.Drawing.Size(298, 148);
            this.Click += new System.EventHandler(this.UCThumbnail_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDate_1;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblOwner_1;
        private System.Windows.Forms.PictureBox pbxStatus;
    }
}
