using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC;
using IHRBLL;
using IHRDAL;
using Model;

namespace HRBLL
{
    public class LoginBLL : ILoginBLL
    {
        ILoginDAL ild = IOCcotainer.CreateStudenDAO();
        public List<LoginModel> SelectBy(LoginModel st)
        {
            return ild.SelectBy(st);
        }

        public int StudentAdd(LoginModel st)
        {
            return ild.StudentAdd(st);
        }

        public int StudentDel(LoginModel st)
        {
            return ild.StudentDel(st);
        }

        public List<LoginModel> StudentSelect()
        {
            return ild.StudentSelect();
        }

        public int StudentUpdate(LoginModel st)
        {
            return ild.StudentUpdate(st);
        }
    }
}
