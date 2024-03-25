namespace Project_JobApp.UCMore
{
    partial class UCJobRow
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblJobID = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnDelJob = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(172, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên CV";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(278, 19);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(62, 16);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Ngày tạo";
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobID.Location = new System.Drawing.Point(48, 19);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(81, 16);
            this.lblJobID.TabIndex = 0;
            this.lblJobID.Text = "ID công việc";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(403, 19);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(32, 16);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Vị trí";
            // 
            // btnDelJob
            // 
            this.btnDelJob.Image = global::Project_JobApp.Properties.Resources.cross_small;
            this.btnDelJob.Location = new System.Drawing.Point(665, 9);
            this.btnDelJob.Name = "btnDelJob";
            this.btnDelJob.Size = new System.Drawing.Size(32, 32);
            this.btnDelJob.TabIndex = 1;
            this.btnDelJob.UseVisualStyleBackColor = true;
            this.btnDelJob.Click += new System.EventHandler(this.btnDelJob_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(508, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Trạng thái";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 2);
            this.panel1.TabIndex = 2;
            // 
            // UCJobRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelJob);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.lblName);
            this.Name = "UCJobRow";
            this.Size = new System.Drawing.Size(700, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnDelJob;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
    }
}
