using Project_JobApp.Classes;
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
                using (var db = new JobAppDFContext())
                {
                    var account = new ACCOUNT
                    {
                        userid = acc.Userid,
                        matkhau = acc.Matkhau,
                        vaitro = acc.Vaitro,
                    };
                    var query = (from q in db.ACCOUNT where q.userid == account.userid select q).ToList();
                    if (query.Count > 0)
                    {
                        MessageBox.Show("Tài khoản không hợp lệ hoặc đã tồn tại!", "Thông báo");
                    }
                    else
                    {
                        db.ACCOUNT.Add(account);
                        db.SaveChanges();
                        if (account.vaitro == "JobSeeker")
                        {
                            var jobseeker = new JOBSEEKER
                            {
                                userid = account.userid,
                            };
                            db.JOBSEEKER.Add(jobseeker);
                            db.SaveChanges();
                        }
                        else if (account.vaitro == "Company")
                        {
                            var company = new COMPANY
                            {
                                userid = account.userid,
                            };
                            db.COMPANY.Add(company);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Đăng kí tài khoản thành công, vui lòng đăng nhập lại!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
