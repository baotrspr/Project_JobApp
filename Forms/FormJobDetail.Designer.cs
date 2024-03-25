namespace Project_JobApp.Forms
{
    partial class FormJobDetail
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
            this.btnApply = new System.Windows.Forms.Button();
            this.lblRequire = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblJobID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dock.SuspendLayout();
            this.pnTab.SuspendLayout();
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
            this.pnTab.BackColor = System.Drawing.Color.White;
            this.pnTab.Controls.Add(this.btnApply);
            this.pnTab.Controls.Add(this.lblRequire);
            this.pnTab.Controls.Add(this.label9);
            this.pnTab.Controls.Add(this.lblProfit);
            this.pnTab.Controls.Add(this.label8);
            this.pnTab.Controls.Add(this.lblField);
            this.pnTab.Controls.Add(this.label7);
            this.pnTab.Controls.Add(this.lblSalary);
            this.pnTab.Controls.Add(this.label6);
            this.pnTab.Controls.Add(this.lblPosition);
            this.pnTab.Controls.Add(this.label5);
            this.pnTab.Controls.Add(this.lblDate);
            this.pnTab.Controls.Add(this.label4);
            this.pnTab.Controls.Add(this.lblUserID);
            this.pnTab.Controls.Add(this.label3);
            this.pnTab.Controls.Add(this.lblJobName);
            this.pnTab.Controls.Add(this.lblJobID);
            this.pnTab.Controls.Add(this.label1);
            this.pnTab.Location = new System.Drawing.Point(8, 38);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(800, 550);
            this.pnTab.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Blue;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(600, 480);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(200, 70);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Ứng tuyển vào công việc";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblRequire
            // 
            this.lblRequire.AutoSize = true;
            this.lblRequire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequire.Location = new System.Drawing.Point(206, 352);
            this.lblRequire.Name = "lblRequire";
            this.lblRequire.Size = new System.Drawing.Size(68, 20);
            this.lblRequire.TabIndex = 0;
            this.lblRequire.Text = "Yêu cầu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Yêu cầu";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(210, 309);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(64, 20);
            this.lblProfit.TabIndex = 0;
            this.lblProfit.Text = "Phúc lợi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phúc lợi";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.Location = new System.Drawing.Point(211, 266);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(67, 20);
            this.lblField.TabIndex = 0;
            this.lblField.Text = "Lĩnh vực";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lĩnh vực";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(211, 223);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(82, 20);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Mức lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mức lương";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(211, 180);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(40, 20);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Vị trí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vị trí";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(211, 137);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày tạo";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(211, 94);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(77, 20);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "Người tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Người tạo";
            // 
            // lblJobName
            // 
            this.lblJobName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblJobName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(0, 0);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(800, 38);
            this.lblJobName.TabIndex = 0;
            this.lblJobName.Text = "Tên công việc";
            this.lblJobName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobID.Location = new System.Drawing.Point(211, 51);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(101, 20);
            this.lblJobID.TabIndex = 0;
            this.lblJobID.Text = "Mã công việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã công việc";
            // 
            // FormJobDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(820, 600);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.dock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJobDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJobDetail";
            this.dock.ResumeLayout(false);
            this.pnTab.ResumeLayout(false);
            this.pnTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dock;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRequire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Button btnApply;
    }
}