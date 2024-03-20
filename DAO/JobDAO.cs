using Project_JobApp.Classes;
using Project_JobApp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.DAO
{
    public class JobDAO
    {
        DBAccess dba = new DBAccess();
        public JobDAO() { }

        public bool Them(Job j)
        {
            string sqlStr = string.Format("insert into CONGVIEC values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                           j.Jobid, j.Tencv, j.Mucluong, j.Linhvuc, j.Thongtin, j.Trinhdo, j.Userid);

            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }
    }
}
