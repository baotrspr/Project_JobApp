namespace Project_JobApp.UC
{
    partial class SeekerUC
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
            this.lblDockerInfo = new System.Windows.Forms.Label();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnDocker.SuspendLayout();
            this.pnNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDocker
            // 
            this.pnDocker.BackColor = System.Drawing.Color.DarkCyan;
            this.pnDocker.Controls.Add(this.lblDockerInfo);
            this.pnDocker.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDocker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDocker.Location = new System.Drawing.Point(0, 0);
            this.pnDocker.Name = "pnDocker";
            this.pnDocker.Size = new System.Drawing.Size(800, 50);
            this.pnDocker.TabIndex = 0;
            // 
            // lblDockerInfo
            // 
            this.lblDockerInfo.AutoSize = true;
            this.lblDockerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDockerInfo.ForeColor = System.Drawing.Color.White;
            this.lblDockerInfo.Location = new System.Drawing.Point(16, 17);
            this.lblDockerInfo.Name = "lblDockerInfo";
            this.lblDockerInfo.Size = new System.Drawing.Size(37, 20);
            this.lblDockerInfo.TabIndex = 0;
            this.lblDockerInfo.Text = "Info";
            // 
            // pnNavigation
            // 
            this.pnNavigation.Controls.Add(this.btnHome);
            this.pnNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNavigation.Location = new System.Drawing.Point(0, 50);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(80, 550);
            this.pnNavigation.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // SeekerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnNavigation);
            this.Controls.Add(this.pnDocker);
            this.Name = "SeekerUC";
            this.Size = new System.Drawing.Size(800, 600);
            this.pnDocker.ResumeLayout(false);
            this.pnDocker.PerformLayout();
            this.pnNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDocker;
        private System.Windows.Forms.Label lblDockerInfo;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Button btnHome;
    }
}
