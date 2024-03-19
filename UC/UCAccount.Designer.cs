﻿namespace Project_JobApp.UC
{
    partial class UCAccount
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtReNewPass = new System.Windows.Forms.TextBox();
            this.lblReNewPass = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnAccInfo = new System.Windows.Forms.Panel();
            this.pnValidate = new System.Windows.Forms.Panel();
            this.pnSpace = new System.Windows.Forms.Panel();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.pnAccInfo.SuspendLayout();
            this.pnValidate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(0, 550);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(800, 50);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa tài khoản";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(0, 500);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(800, 50);
            this.btnChangePass.TabIndex = 12;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(215, 64);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 19);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(215, 15);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(58, 19);
            this.lblUserID.TabIndex = 10;
            this.lblUserID.Text = "User ID";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(373, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(180, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(373, 12);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(180, 26);
            this.txtUserID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "TRUNG TÂM TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(373, 54);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.Size = new System.Drawing.Size(180, 26);
            this.txtNewPass.TabIndex = 7;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(215, 57);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(93, 19);
            this.lblNewPass.TabIndex = 9;
            this.lblNewPass.Text = "Mật khẩu mới";
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReNewPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReNewPass.Location = new System.Drawing.Point(373, 103);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.PasswordChar = '●';
            this.txtReNewPass.Size = new System.Drawing.Size(180, 26);
            this.txtReNewPass.TabIndex = 7;
            // 
            // lblReNewPass
            // 
            this.lblReNewPass.AutoSize = true;
            this.lblReNewPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReNewPass.Location = new System.Drawing.Point(215, 106);
            this.lblReNewPass.Name = "lblReNewPass";
            this.lblReNewPass.Size = new System.Drawing.Size(145, 19);
            this.lblReNewPass.TabIndex = 9;
            this.lblReNewPass.Text = "Nhập lại mật khẩu mới";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblConfirm.Location = new System.Drawing.Point(574, 9);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(142, 19);
            this.lblConfirm.TabIndex = 9;
            this.lblConfirm.Text = "Xác nhận lại mật khẩu";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(342, 156);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(127, 41);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnAccInfo
            // 
            this.pnAccInfo.Controls.Add(this.txtPassword);
            this.pnAccInfo.Controls.Add(this.txtUserID);
            this.pnAccInfo.Controls.Add(this.lblUserID);
            this.pnAccInfo.Controls.Add(this.lblPassword);
            this.pnAccInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAccInfo.Location = new System.Drawing.Point(0, 155);
            this.pnAccInfo.Name = "pnAccInfo";
            this.pnAccInfo.Size = new System.Drawing.Size(800, 100);
            this.pnAccInfo.TabIndex = 14;
            // 
            // pnValidate
            // 
            this.pnValidate.Controls.Add(this.txtOldPass);
            this.pnValidate.Controls.Add(this.btnConfirm);
            this.pnValidate.Controls.Add(this.txtNewPass);
            this.pnValidate.Controls.Add(this.lblOldPass);
            this.pnValidate.Controls.Add(this.lblConfirm);
            this.pnValidate.Controls.Add(this.txtReNewPass);
            this.pnValidate.Controls.Add(this.lblNewPass);
            this.pnValidate.Controls.Add(this.lblReNewPass);
            this.pnValidate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnValidate.Location = new System.Drawing.Point(0, 255);
            this.pnValidate.Name = "pnValidate";
            this.pnValidate.Size = new System.Drawing.Size(800, 225);
            this.pnValidate.TabIndex = 15;
            // 
            // pnSpace
            // 
            this.pnSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace.Location = new System.Drawing.Point(0, 55);
            this.pnSpace.Name = "pnSpace";
            this.pnSpace.Size = new System.Drawing.Size(800, 100);
            this.pnSpace.TabIndex = 16;
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Location = new System.Drawing.Point(215, 9);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(85, 19);
            this.lblOldPass.TabIndex = 9;
            this.lblOldPass.Text = "Mật khẩu cũ";
            // 
            // txtOldPass
            // 
            this.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Location = new System.Drawing.Point(373, 6);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '●';
            this.txtOldPass.Size = new System.Drawing.Size(180, 26);
            this.txtOldPass.TabIndex = 7;
            // 
            // UCAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnValidate);
            this.Controls.Add(this.pnAccInfo);
            this.Controls.Add(this.pnSpace);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Name = "UCAccount";
            this.Size = new System.Drawing.Size(800, 600);
            this.pnAccInfo.ResumeLayout(false);
            this.pnAccInfo.PerformLayout();
            this.pnValidate.ResumeLayout(false);
            this.pnValidate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtReNewPass;
        private System.Windows.Forms.Label lblReNewPass;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnAccInfo;
        private System.Windows.Forms.Panel pnValidate;
        private System.Windows.Forms.Panel pnSpace;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label lblOldPass;
    }
}
