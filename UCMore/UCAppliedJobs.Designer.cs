namespace Project_JobApp.UCMore
{
    partial class UCAppliedJobs
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
            this.lblJobID = new System.Windows.Forms.Label();
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTencv = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJobID
            // 
            this.lblJobID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobID.Location = new System.Drawing.Point(3, 17);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(93, 18);
            this.lblJobID.TabIndex = 0;
            this.lblJobID.Text = "Mã CV";
            this.lblJobID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxStatus
            // 
            this.pbxStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxStatus.Location = new System.Drawing.Point(655, 11);
            this.pbxStatus.Name = "pbxStatus";
            this.pbxStatus.Size = new System.Drawing.Size(32, 32);
            this.pbxStatus.TabIndex = 1;
            this.pbxStatus.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 2);
            this.panel1.TabIndex = 2;
            // 
            // lblTencv
            // 
            this.lblTencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTencv.Location = new System.Drawing.Point(111, 17);
            this.lblTencv.Name = "lblTencv";
            this.lblTencv.Size = new System.Drawing.Size(128, 18);
            this.lblTencv.TabIndex = 0;
            this.lblTencv.Text = "TênCV";
            this.lblTencv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(254, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(122, 18);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Thời gian";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(391, 17);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(158, 18);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Công ty";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Project_JobApp.Properties.Resources.cross_small;
            this.btnCancel.Location = new System.Drawing.Point(577, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(32, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UCAppliedJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxStatus);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTencv);
            this.Controls.Add(this.lblJobID);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCAppliedJobs";
            this.Size = new System.Drawing.Size(700, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.PictureBox pbxStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTencv;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnCancel;
    }
}
