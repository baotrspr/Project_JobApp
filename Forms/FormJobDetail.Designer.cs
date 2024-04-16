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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblYeucau = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPhucloi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMota = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llblXemCty = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMacv = new System.Windows.Forms.Label();
            this.btnUngtuyen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNgaytao = new System.Windows.Forms.Label();
            this.lblLinhvuc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVitri = new System.Windows.Forms.Label();
            this.lblDadangki = new System.Windows.Forms.Label();
            this.lblHandangki = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.dock.SuspendLayout();
            this.pnTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dock
            // 
            this.dock.BackColor = System.Drawing.Color.DarkViolet;
            this.dock.Controls.Add(this.btnBack);
            this.dock.Dock = System.Windows.Forms.DockStyle.Top;
            this.dock.Location = new System.Drawing.Point(0, 0);
            this.dock.Name = "dock";
            this.dock.Size = new System.Drawing.Size(930, 30);
            this.dock.TabIndex = 1;
            this.dock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dock_MouseDown);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Brown;
            this.btnBack.Location = new System.Drawing.Point(855, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "X";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnTab
            // 
            this.pnTab.AutoScroll = true;
            this.pnTab.BackColor = System.Drawing.Color.White;
            this.pnTab.Controls.Add(this.groupBox2);
            this.pnTab.Controls.Add(this.groupBox1);
            this.pnTab.Controls.Add(this.lblJobName);
            this.pnTab.Location = new System.Drawing.Point(8, 38);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(920, 650);
            this.pnTab.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lblYeucau);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblPhucloi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblMota);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(903, 431);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // lblYeucau
            // 
            this.lblYeucau.AutoSize = true;
            this.lblYeucau.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYeucau.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYeucau.Location = new System.Drawing.Point(3, 328);
            this.lblYeucau.MaximumSize = new System.Drawing.Size(900, 500);
            this.lblYeucau.MinimumSize = new System.Drawing.Size(900, 100);
            this.lblYeucau.Name = "lblYeucau";
            this.lblYeucau.Size = new System.Drawing.Size(900, 100);
            this.lblYeucau.TabIndex = 0;
            this.lblYeucau.Text = "Yêu cầu";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(897, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "Yêu cầu";
            // 
            // lblPhucloi
            // 
            this.lblPhucloi.AutoSize = true;
            this.lblPhucloi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhucloi.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhucloi.Location = new System.Drawing.Point(3, 193);
            this.lblPhucloi.MaximumSize = new System.Drawing.Size(900, 500);
            this.lblPhucloi.MinimumSize = new System.Drawing.Size(900, 100);
            this.lblPhucloi.Name = "lblPhucloi";
            this.lblPhucloi.Size = new System.Drawing.Size(900, 100);
            this.lblPhucloi.TabIndex = 0;
            this.lblPhucloi.Text = "Phúc lợi";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(897, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phúc lợi";
            // 
            // lblMota
            // 
            this.lblMota.AutoSize = true;
            this.lblMota.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMota.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMota.Location = new System.Drawing.Point(3, 58);
            this.lblMota.MaximumSize = new System.Drawing.Size(900, 500);
            this.lblMota.MinimumSize = new System.Drawing.Size(900, 100);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(900, 100);
            this.lblMota.TabIndex = 0;
            this.lblMota.Text = "Mô tả";
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(897, 35);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mô tả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llblXemCty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMacv);
            this.groupBox1.Controls.Add(this.btnUngtuyen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNgaytao);
            this.groupBox1.Controls.Add(this.lblLinhvuc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblVitri);
            this.groupBox1.Controls.Add(this.lblDadangki);
            this.groupBox1.Controls.Add(this.lblHandangki);
            this.groupBox1.Controls.Add(this.lblSoluong);
            this.groupBox1.Controls.Add(this.lblLuong);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 277);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cơ bản";
            // 
            // llblXemCty
            // 
            this.llblXemCty.AutoSize = true;
            this.llblXemCty.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblXemCty.Location = new System.Drawing.Point(164, 85);
            this.llblXemCty.Name = "llblXemCty";
            this.llblXemCty.Size = new System.Drawing.Size(79, 21);
            this.llblXemCty.TabIndex = 3;
            this.llblXemCty.TabStop = true;
            this.llblXemCty.Text = "Người tạo";
            this.llblXemCty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblXemCty_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã công việc";
            // 
            // lblMacv
            // 
            this.lblMacv.AutoSize = true;
            this.lblMacv.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacv.Location = new System.Drawing.Point(164, 42);
            this.lblMacv.Name = "lblMacv";
            this.lblMacv.Size = new System.Drawing.Size(100, 21);
            this.lblMacv.TabIndex = 0;
            this.lblMacv.Text = "Mã công việc";
            // 
            // btnUngtuyen
            // 
            this.btnUngtuyen.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUngtuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUngtuyen.ForeColor = System.Drawing.Color.White;
            this.btnUngtuyen.Location = new System.Drawing.Point(67, 229);
            this.btnUngtuyen.Name = "btnUngtuyen";
            this.btnUngtuyen.Size = new System.Drawing.Size(768, 42);
            this.btnUngtuyen.TabIndex = 1;
            this.btnUngtuyen.Text = "Ứng tuyển vào công việc";
            this.btnUngtuyen.UseVisualStyleBackColor = false;
            this.btnUngtuyen.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Người tạo";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(164, 85);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(0, 21);
            this.lblUserID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày tạo";
            // 
            // lblNgaytao
            // 
            this.lblNgaytao.AutoSize = true;
            this.lblNgaytao.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaytao.Location = new System.Drawing.Point(615, 42);
            this.lblNgaytao.Name = "lblNgaytao";
            this.lblNgaytao.Size = new System.Drawing.Size(72, 21);
            this.lblNgaytao.TabIndex = 0;
            this.lblNgaytao.Text = "Ngày tạo";
            // 
            // lblLinhvuc
            // 
            this.lblLinhvuc.AutoSize = true;
            this.lblLinhvuc.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinhvuc.Location = new System.Drawing.Point(615, 85);
            this.lblLinhvuc.Name = "lblLinhvuc";
            this.lblLinhvuc.Size = new System.Drawing.Size(66, 21);
            this.lblLinhvuc.TabIndex = 0;
            this.lblLinhvuc.Text = "Lĩnh vực";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vị trí";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(434, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lĩnh vực";
            // 
            // lblVitri
            // 
            this.lblVitri.AutoSize = true;
            this.lblVitri.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitri.Location = new System.Drawing.Point(164, 124);
            this.lblVitri.Name = "lblVitri";
            this.lblVitri.Size = new System.Drawing.Size(42, 21);
            this.lblVitri.TabIndex = 0;
            this.lblVitri.Text = "Vị trí";
            // 
            // lblDadangki
            // 
            this.lblDadangki.AutoSize = true;
            this.lblDadangki.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadangki.Location = new System.Drawing.Point(615, 206);
            this.lblDadangki.Name = "lblDadangki";
            this.lblDadangki.Size = new System.Drawing.Size(71, 21);
            this.lblDadangki.TabIndex = 0;
            this.lblDadangki.Text = "Số lượng";
            // 
            // lblHandangki
            // 
            this.lblHandangki.AutoSize = true;
            this.lblHandangki.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandangki.Location = new System.Drawing.Point(615, 167);
            this.lblHandangki.Name = "lblHandangki";
            this.lblHandangki.Size = new System.Drawing.Size(93, 21);
            this.lblHandangki.TabIndex = 0;
            this.lblHandangki.Text = "Hạn đăng kí";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(615, 124);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(71, 21);
            this.lblSoluong.TabIndex = 0;
            this.lblSoluong.Text = "Số lượng";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(164, 167);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(84, 21);
            this.lblLuong.TabIndex = 0;
            this.lblLuong.Text = "Mức lương";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(434, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Số lượng ứng tuyển";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(434, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Hạn đăng kí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mức lương";
            // 
            // lblJobName
            // 
            this.lblJobName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblJobName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(0, 0);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(903, 38);
            this.lblJobName.TabIndex = 0;
            this.lblJobName.Text = "Tên công việc";
            this.lblJobName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormJobDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(930, 700);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.dock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJobDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJobDetail";
            this.dock.ResumeLayout(false);
            this.pnTab.ResumeLayout(false);
            this.pnTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lblYeucau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPhucloi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLinhvuc;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblVitri;
        private System.Windows.Forms.Label lblNgaytao;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblMacv;
        private System.Windows.Forms.Button btnUngtuyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMota;
        private System.Windows.Forms.Label lblDadangki;
        private System.Windows.Forms.Label lblHandangki;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llblXemCty;
    }
}