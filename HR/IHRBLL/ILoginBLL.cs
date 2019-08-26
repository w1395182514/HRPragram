﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IHRBLL
{
     public interface ILoginBLL
    {
        int StudentAdd(LoginModel st);
        int StudentDel(LoginModel st);
        int StudentUpdate(LoginModel st);
        List<LoginModel> StudentSelect();
        List<LoginModel> SelectBy(LoginModel st);
    }
}
