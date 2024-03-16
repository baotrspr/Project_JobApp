using Project_JobApp.Classes;
using Project_JobApp.Database;
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
                if (dba.Execute(sqlStr))
                {
                    MessageBox.Show("Tk da ton tai");
                }
                else
                {
                    sqlStr = string.Format($"insert into TAIKHOAN(userid, matkhau, vaitro) values ('{acc.Userid}', '{acc.Matkhau}', '{acc.Vaitro}')");
                    dba.Execute(sqlStr);
                    MessageBox.Show("Tk da ton tai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
