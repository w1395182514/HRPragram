using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFentity;
using IHRDAL;
using System.Data;

namespace HRDAL
{
    public class LoginDAL:DaoBase<Student>,ILoginDAL
    {
        public int StudentAdd(LoginModel st)
        {
            Student est = new Student()
            {
                Id = st.Id,
                Name = st.Name
            };
            return Add(est);
        }

        public int StudentDel(LoginModel st)
        {
            Student est = new Student()
            {
                Id = st.Id,
            };
            return Delete(est);
        }

        public List<LoginModel> StudentSelect()
        {
            List<Student> list = SelectAll();
            List<LoginModel> list2 = new List<LoginModel>();
            foreach (Student item in list)
            {
                LoginModel sm = new LoginModel()
                {
                    Id = item.Id,
                    Name = item.Name
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int StudentUpdate(Model.LoginModel st)
        {
            Student est = new Student()
            {
                Id = st.Id,
                Name = st.Name
            };
            return Update(est);
        }

        public List<LoginModel> SelectBy(LoginModel st)
        {
            List<Student> list = SelectBy(e => e.Id.Equals(st.Id));
            List<LoginModel> list2 = new List<LoginModel>();
            foreach (Student item in list)
            {
                LoginModel sm = new LoginModel()
                {
                    Id = item.Id,
                    Name = item.Name
                };
                list2.Add(sm);
            }
            return list2;
        }

        public DataTable Login(LoginModel m)
        {
            string sql = $"select * from users where u_name = {m.Name} and u_password = {m.PassWorld}";
            return DBHelper.SelectTable(sql);
        }
    }
}
