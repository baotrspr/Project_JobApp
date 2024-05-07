namespace Project_JobApp.UC
{
    partial class UCHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHome));
            this.count = new System.Windows.Forms.Timer(this.components);
            this.pnTime = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblFullDay = new System.Windows.Forms.Label();
            this.pnTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.Tick += new System.EventHandler(this.count_Tick);
            // 
            // pnTime
            // 
            this.pnTime.BackColor = System.Drawing.Color.Indigo;
            this.pnTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnTime.BackgroundImage")));
            this.pnTime.Controls.Add(this.lblYear);
            this.pnTime.Controls.Add(this.lblTime);
            this.pnTime.Controls.Add(this.lblDay);
            this.pnTime.Controls.Add(this.lblMonth);
            this.pnTime.Controls.Add(this.lblFullDay);
            this.pnTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTime.Location = new System.Drawing.Point(0, 0);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(1100, 800);
            this.pnTime.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYear.Location = new System.Drawing.Point(835, 19);
            this.lblYear.Name = "lblYear";
            this.lblYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYear.Size = new System.Drawing.Size(168, 73);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(105, 9);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(275, 86);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDay.Location = new System.Drawing.Point(529, 49);
            this.lblDay.Name = "lblDay";
            this.lblDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDay.Size = new System.Drawing.Size(73, 37);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Day";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMonth.Location = new System.Drawing.Point(608, 49);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMonth.Size = new System.Drawing.Size(106, 37);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFullDay
            // 
            this.lblFullDay.AutoSize = true;
            this.lblFullDay.BackColor = System.Drawing.Color.Transparent;
            this.lblFullDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullDay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFullDay.Location = new System.Drawing.Point(387, 49);
            this.lblFullDay.Name = "lblFullDay";
            this.lblFullDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFullDay.Size = new System.Drawing.Size(125, 37);
            this.lblFullDay.TabIndex = 0;
            this.lblFullDay.Text = "FullDay";
            this.lblFullDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTime);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1100, 800);
            this.Load += new System.EventHandler(this.UCHome_Load);
            this.pnTime.ResumeLayout(false);
            this.pnTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer count;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblFullDay;
        private System.Windows.Forms.Panel pnTime;
    }
}
