namespace Project_JobApp.Forms
{
    partial class FormLoinhan
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
            this.rtxtLoinhan = new System.Windows.Forms.RichTextBox();
            this.lblLoinhan = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtLoinhan
            // 
            this.rtxtLoinhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtLoinhan.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtLoinhan.Location = new System.Drawing.Point(171, 24);
            this.rtxtLoinhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtLoinhan.Name = "rtxtLoinhan";
            this.rtxtLoinhan.Size = new System.Drawing.Size(600, 30);
            this.rtxtLoinhan.TabIndex = 21;
            this.rtxtLoinhan.Text = "";
            // 
            // lblLoinhan
            // 
            this.lblLoinhan.AutoSize = true;
            this.lblLoinhan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoinhan.Location = new System.Drawing.Point(21, 29);
            this.lblLoinhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoinhan.Name = "lblLoinhan";
            this.lblLoinhan.Size = new System.Drawing.Size(111, 21);
            this.lblLoinhan.TabIndex = 20;
            this.lblLoinhan.Text = "Để lại lời nhắn";
            this.lblLoinhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(265, 87);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(260, 40);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "Xong";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rtxtLoinhan);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.lblLoinhan);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 150);
            this.panel1.TabIndex = 23;
            // 
            // FormLoinhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 160);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLoinhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoinhan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtLoinhan;
        private System.Windows.Forms.Label lblLoinhan;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
    }
}