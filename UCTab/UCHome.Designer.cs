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
            this.lblTime = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Timer(this.components);
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblFullDay = new System.Windows.Forms.Label();
            this.pnTime = new System.Windows.Forms.Panel();
            this.pnNew = new System.Windows.Forms.Panel();
            this.pnNotify = new System.Windows.Forms.Panel();
            this.pnTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(87, 66);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(417, 108);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";
            // 
            // count
            // 
            this.count.Tick += new System.EventHandler(this.count_Tick);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDay.Location = new System.Drawing.Point(249, 178);
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
            this.lblMonth.Location = new System.Drawing.Point(328, 178);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMonth.Size = new System.Drawing.Size(106, 37);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYear.Location = new System.Drawing.Point(315, 215);
            this.lblYear.Name = "lblYear";
            this.lblYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYear.Size = new System.Drawing.Size(168, 73);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFullDay
            // 
            this.lblFullDay.AutoSize = true;
            this.lblFullDay.BackColor = System.Drawing.Color.Transparent;
            this.lblFullDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullDay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFullDay.Location = new System.Drawing.Point(107, 178);
            this.lblFullDay.Name = "lblFullDay";
            this.lblFullDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFullDay.Size = new System.Drawing.Size(125, 37);
            this.lblFullDay.TabIndex = 0;
            this.lblFullDay.Text = "FullDay";
            this.lblFullDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnTime
            // 
            this.pnTime.BackColor = System.Drawing.Color.Indigo;
            this.pnTime.Controls.Add(this.lblYear);
            this.pnTime.Controls.Add(this.lblTime);
            this.pnTime.Controls.Add(this.lblDay);
            this.pnTime.Controls.Add(this.lblMonth);
            this.pnTime.Controls.Add(this.lblFullDay);
            this.pnTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTime.Location = new System.Drawing.Point(436, 0);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(564, 356);
            this.pnTime.TabIndex = 1;
            // 
            // pnNew
            // 
            this.pnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNew.Location = new System.Drawing.Point(0, 0);
            this.pnNew.Name = "pnNew";
            this.pnNew.Size = new System.Drawing.Size(436, 700);
            this.pnNew.TabIndex = 2;
            // 
            // pnNotify
            // 
            this.pnNotify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNotify.Location = new System.Drawing.Point(436, 356);
            this.pnNotify.Name = "pnNotify";
            this.pnNotify.Size = new System.Drawing.Size(564, 344);
            this.pnNotify.TabIndex = 3;
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnNotify);
            this.Controls.Add(this.pnTime);
            this.Controls.Add(this.pnNew);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1000, 700);
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
        private System.Windows.Forms.Panel pnNew;
        private System.Windows.Forms.Panel pnNotify;
    }
}
