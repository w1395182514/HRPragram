using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHRDAL;
using IOC;
using IHRBLL;
using Model;
using System.Data;

namespace HRBLL
{
    public class config_major_kindBLL : Iconfig_major_kindBLL
    {
        Iconfig_major_kindDAL icmkd = IOCcotainer.Createconfig_major_kindDAO();
        public int Add(config_major_kindModel cm)
        {
            return icmkd.Add(cm);
        }

        public int Del(config_major_kindModel cm)
        {
            return icmkd.Del(cm);
        }

        public object MaxId()
        {
            return icmkd.MaxId();
        }

        public List<config_major_kindModel> Select()
        {
            return icmkd.Select();
        }

        public List<config_major_kindModel> SelectBy(config_major_kindModel cm)
        {
            return icmkd.SelectBy(cm);
        }

        public string SelectById(object id)
        {
            return icmkd.SelectById(id);
        }

        public DataTable SelectType()
        {
            return icmkd.SelectType();
        }

        public int Update(config_major_kindModel cm)
        {
            return icmkd.Update(cm);
        }
    }
}
