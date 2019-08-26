using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHRBLL;
using IHRDAL;
using IOC;
using Model;

namespace HRBLL
{
    public class config_majorBLL : Iconfig_majorBLL
    {
        Iconfig_majorDAL icmd = IOCcotainer.Createconfig_majorDAO();
        public int Add(config_majorModel cm)
        {
            return icmd.Add(cm);
        }

        public int Del(config_majorModel cm)
        {
            return icmd.Del(cm);
        }

        public List<config_majorModel> Select()
        {
            return icmd.Select();
        }

        public List<config_majorModel> SelectBy(config_majorModel cm)
        {
            return icmd.SelectBy(cm);
        }

        public int Update(config_majorModel cm)
        {
            return icmd.Update(cm);
        }
    }
}
