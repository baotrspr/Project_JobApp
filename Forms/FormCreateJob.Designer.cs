namespace Project_JobApp.Forms
{
    partial class FormCreateJob
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.ucJobDetail = new Project_JobApp.UC.UCJobDetail();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 25);
            this.panel1.TabIndex = 3;
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJob.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJob.ForeColor = System.Drawing.Color.White;
            this.btnAddJob.Location = new System.Drawing.Point(226, 457);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(158, 40);
            this.btnAddJob.TabIndex = 5;
            this.btnAddJob.Text = "Thêm Job";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // ucJobDetail
            // 
            this.ucJobDetail.Jobid = "";
            this.ucJobDetail.Linhvuc = "";
            this.ucJobDetail.Location = new System.Drawing.Point(12, 54);
            this.ucJobDetail.Mucluong = "";
            this.ucJobDetail.Name = "ucJobDetail";
            this.ucJobDetail.Size = new System.Drawing.Size(575, 397);
            this.ucJobDetail.TabIndex = 4;
            this.ucJobDetail.Tencv = "";
            this.ucJobDetail.Thongtin = "";
            this.ucJobDetail.Trinhdo = "";
            this.ucJobDetail.Userid = "";
            // 
            // FormCreateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.ucJobDetail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateJob";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UC.UCJobDetail ucJobDetail;
        private System.Windows.Forms.Button btnAddJob;
    }
}