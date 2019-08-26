using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC;
using IHRBLL;
using Model;
using IHRDAL;
using System.Data;

namespace HRBLL
{
    public class config_file_third_kindBLL : Iconfig_file_third_kindBLL
    {
        Iconfig_file_third_kindDAL ft = IOCcotainer.Createconfig_file_third_kindDAO();
        public List<config_file_third_kindModel> FTKAll()
        {
            return ft.FTKAll();
        }

        public int FTAdd(config_file_third_kindModel t)
        {
            return ft.FTAdd(t);
        }

        public DataTable CX1()
        {
            return ft.CX1();
        }

        public DataTable CX2()
        {
            return ft.CX2();
        }
    }
}
