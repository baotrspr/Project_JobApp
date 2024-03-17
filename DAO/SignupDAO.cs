﻿using Project_JobApp.Classes;
using Project_JobApp.Database;
using Project_JobApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.DAO
{
    internal class SignupDAO
    {
        DBAccess dba = new DBAccess();
        public SignupDAO() { }

        public void Signup(Account acc)
        {
            try
            {
                string sqlStr = string.Format($"select userid from TAIKHOAN where userid = '{acc.Userid}'");
                if (dba.ExecuteSelect(sqlStr).Rows.Count > 0)
                {
                    MessageBox.Show("Tài khoản không hợp lệ hoặc đã tồn tại!", "Thông báo");
                }
                else
                {
                    sqlStr = string.Format($"insert into TAIKHOAN(userid, matkhau, vaitro) values ('{acc.Userid}', '{acc.Matkhau}', '{acc.Vaitro}')");
                    if(dba.Execute(sqlStr))
                        MessageBox.Show("Đăng kí tài khoản thành công, vui lòng đăng nhập lại!", "Thông báo");
                    else
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
