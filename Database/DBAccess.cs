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

        public void Excute(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thao tac thanh cong!", "Action Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tac khong thanh cong!\n" + ex.Message, "Action Failed");
            }
            finally
            { 
                conn.Close(); 
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
    }
}
