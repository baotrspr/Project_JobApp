namespace Project_JobApp.UC
{
    partial class UCAppliedJob
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
            this.pnContent = new System.Windows.Forms.Panel();
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 55);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.flpList);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 55);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(800, 545);
            this.pnContent.TabIndex = 2;
            // 
            // flpList
            // 
            this.flpList.AutoScroll = true;
            this.flpList.BackColor = System.Drawing.Color.White;
            this.flpList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpList.Location = new System.Drawing.Point(50, 50);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(700, 450);
            this.flpList.TabIndex = 0;
            // 
            // UCAppliedJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCAppliedJob";
            this.Size = new System.Drawing.Size(800, 600);
            this.pnContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.FlowLayoutPanel flpList;
    }
}
