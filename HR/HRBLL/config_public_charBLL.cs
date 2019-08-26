using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHRBLL;
using IOC;
using IHRDAL;
using Model;

namespace HRBLL
{
    public class config_public_charBLL : Iconfig_public_charBLL
    {
        Iconfig_public_charDAL icpcd = IOCcotainer.Createconfig_public_charDAO();
        public int Add(config_public_charModel cm)
        {
            return icpcd.Add(cm);
        }

        public int Del(config_public_charModel cm)
        {
            return icpcd.Del(cm);
        }

        public List<config_public_charModel> Select()
        {
            return icpcd.Select();
        }

        public List<config_public_charModel> SelectBy(config_public_charModel cm)
        {
            return icpcd.SelectBy(cm);
        }

        public int Update(config_public_charModel cm)
        {
            return icpcd.Update(cm);
        }
    }
}
