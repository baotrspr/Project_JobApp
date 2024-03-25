using Project_JobApp.Classes;
using Project_JobApp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.DAO
{
    public class CongviecDAO
    {
        DBAccess dba = new DBAccess();
        public CongviecDAO() { }

        public DataTable GetData()
        {
            string sqlStr = string.Format("select * from CONGVIEC");
            return dba.ExecuteSelect(sqlStr);
        }

        public bool Them(Job j)
        {
            string sqlStr = string.Format("insert into CONGVIEC values ('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}',N'{6}', N'{7}',N'{8}', N'{9}')",
                                            j.Jobid, j.Userid, j.Tencv, j.Ngaytao, j.Vitri, j.Mucluong, j.Linhvuc, j.Phucloi, j.Yeucau, "waiting");
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }

        public bool Xoa(Job j)
        {
            string sqlStr = string.Format("delete from CONGVIEC where jobid = '{0}'", j.Jobid);
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }
    }
}
