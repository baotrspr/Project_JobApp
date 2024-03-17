using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Project_JobApp.Database
{
    //Chứa thủ tục thực thi truy vấn csdl
    internal class DBAccess
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnn);

        public bool Execute(string sqlStr)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            var query = cmd.ExecuteNonQuery();
            conn.Close();
            if (query > 0) return true; else return false;
        }

        public DataTable ExecuteSelect(string sqlStr)
        {
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }

        public DataTable Reload(string sqlStr)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataRow SelectRow(string sqlStr)
        {
            DataRow dr = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            conn.Close();
            return dr;
        }

    }
}
