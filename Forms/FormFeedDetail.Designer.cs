namespace Project_JobApp.Forms
{
    partial class FormFeedDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dock = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnTab = new System.Windows.Forms.Panel();
            this.dock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dock
            // 
            this.dock.Controls.Add(this.btnBack);
            this.dock.Dock = System.Windows.Forms.DockStyle.Top;
            this.dock.Location = new System.Drawing.Point(0, 0);
            this.dock.Name = "dock";
            this.dock.Size = new System.Drawing.Size(820, 30);
            this.dock.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Honeydew;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::Project_JobApp.Properties.Resources.arrow_small_left;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "h";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnTab
            // 
            this.pnTab.Location = new System.Drawing.Point(8, 38);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(800, 550);
            this.pnTab.TabIndex = 2;
            // 
            // FormFeedDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(820, 600);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.dock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFeedDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFeedDetail";
            this.Load += new System.EventHandler(this.FormFeedDetail_Load);
            this.dock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dock;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnTab;
    }
}