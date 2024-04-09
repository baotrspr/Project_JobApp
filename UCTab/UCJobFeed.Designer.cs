namespace Project_JobApp.UC
{
    partial class UCJobFeed
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.flpData = new System.Windows.Forms.FlowLayoutPanel();
            this.pnSort = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbField = new System.Windows.Forms.RadioButton();
            this.rdbSalary = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnCancelFilter = new System.Windows.Forms.Button();
            this.cbxField = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "JOB FEED";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(848, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(152, 50);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo bài đăng mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // flpData
            // 
            this.flpData.AutoScroll = true;
            this.flpData.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpData.Location = new System.Drawing.Point(207, 50);
            this.flpData.Name = "flpData";
            this.flpData.Size = new System.Drawing.Size(793, 650);
            this.flpData.TabIndex = 3;
            // 
            // pnSort
            // 
            this.pnSort.Controls.Add(this.cbxField);
            this.pnSort.Controls.Add(this.btnCancelFilter);
            this.pnSort.Controls.Add(this.btnFilter);
            this.pnSort.Controls.Add(this.txtInput);
            this.pnSort.Controls.Add(this.rdbSalary);
            this.pnSort.Controls.Add(this.label3);
            this.pnSort.Controls.Add(this.label2);
            this.pnSort.Controls.Add(this.rdbField);
            this.pnSort.Controls.Add(this.rdbAll);
            this.pnSort.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSort.Location = new System.Drawing.Point(0, 50);
            this.pnSort.Name = "pnSort";
            this.pnSort.Size = new System.Drawing.Size(205, 650);
            this.pnSort.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bộ lọc";
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAll.Location = new System.Drawing.Point(20, 55);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(65, 23);
            this.rdbAll.TabIndex = 0;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Tất cả";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // rdbField
            // 
            this.rdbField.AutoSize = true;
            this.rdbField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbField.Location = new System.Drawing.Point(20, 85);
            this.rdbField.Name = "rdbField";
            this.rdbField.Size = new System.Drawing.Size(109, 23);
            this.rdbField.TabIndex = 1;
            this.rdbField.TabStop = true;
            this.rdbField.Text = "Theo lĩnh vực";
            this.rdbField.UseVisualStyleBackColor = true;
            this.rdbField.CheckedChanged += new System.EventHandler(this.rdbField_CheckedChanged);
            // 
            // rdbSalary
            // 
            this.rdbSalary.AutoSize = true;
            this.rdbSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSalary.Location = new System.Drawing.Point(20, 158);
            this.rdbSalary.Name = "rdbSalary";
            this.rdbSalary.Size = new System.Drawing.Size(127, 23);
            this.rdbSalary.TabIndex = 1;
            this.rdbSalary.TabStop = true;
            this.rdbSalary.Text = "Theo mức lương";
            this.rdbSalary.UseVisualStyleBackColor = true;
            this.rdbSalary.CheckedChanged += new System.EventHandler(this.rdbSalary_CheckedChanged);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(38, 221);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(156, 26);
            this.txtInput.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập giá trị lọc";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(7, 296);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(92, 35);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFilter.Location = new System.Drawing.Point(105, 296);
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.Size = new System.Drawing.Size(94, 35);
            this.btnCancelFilter.TabIndex = 3;
            this.btnCancelFilter.Text = "Hủy bộ lọc";
            this.btnCancelFilter.UseVisualStyleBackColor = true;
            this.btnCancelFilter.Click += new System.EventHandler(this.btnCancelFilter_Click);
            // 
            // cbxField
            // 
            this.cbxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxField.FormattingEnabled = true;
            this.cbxField.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Thiết kế đồ họa",
            "Kinh tế",
            "Kinh doanh",
            "Công nghệ chế tạo máy",
            "Ngoại ngữ",
            "Giáo dục",
            "Trí tuệ nhân tạo",
            "Hàng không",
            "Giao thông vận tải",
            "Xây dựng",
            "Kiến trúc",
            "Ngân hàng",
            "Hàng hải",
            "Logistic",
            "Dịch vụ",
            "Khác..."});
            this.cbxField.Location = new System.Drawing.Point(38, 120);
            this.cbxField.Name = "cbxField";
            this.cbxField.Size = new System.Drawing.Size(156, 27);
            this.cbxField.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(205, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 650);
            this.panel2.TabIndex = 5;
            // 
            // UCJobFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnSort);
            this.Controls.Add(this.flpData);
            this.Controls.Add(this.panel1);
            this.Name = "UCJobFeed";
            this.Size = new System.Drawing.Size(1000, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnSort.ResumeLayout(false);
            this.pnSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpData;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rdbSalary;
        private System.Windows.Forms.RadioButton rdbField;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbxField;
        private System.Windows.Forms.Panel panel2;
    }
}
