namespace Project_JobApp.Forms
{
    partial class FormViewApplicants
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTieude = new System.Windows.Forms.Label();
            this.flpDanhsach = new System.Windows.Forms.FlowLayoutPanel();
            this.dock.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dock
            // 
            this.dock.BackColor = System.Drawing.Color.Indigo;
            this.dock.Controls.Add(this.btnExit);
            this.dock.Dock = System.Windows.Forms.DockStyle.Top;
            this.dock.Location = new System.Drawing.Point(0, 0);
            this.dock.Name = "dock";
            this.dock.Size = new System.Drawing.Size(800, 30);
            this.dock.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flpDanhsach);
            this.panel1.Controls.Add(this.lblTieude);
            this.panel1.Controls.Add(this.dock);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 630);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(770, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTieude
            // 
            this.lblTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieude.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieude.Location = new System.Drawing.Point(0, 30);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(800, 70);
            this.lblTieude.TabIndex = 1;
            this.lblTieude.Text = "Danh sách ứng tuyển cho công việc";
            this.lblTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpDanhsach
            // 
            this.flpDanhsach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDanhsach.Location = new System.Drawing.Point(0, 100);
            this.flpDanhsach.Name = "flpDanhsach";
            this.flpDanhsach.Size = new System.Drawing.Size(800, 530);
            this.flpDanhsach.TabIndex = 2;
            // 
            // FormViewApplicants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(806, 636);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewApplicants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewApplicants";
            this.Load += new System.EventHandler(this.FormViewApplicants_Load);
            this.dock.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.FlowLayoutPanel flpDanhsach;
    }
}