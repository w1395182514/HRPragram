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
    public class FirstKindBLL : IFirstKindBLL
    {
        IFirstKindDAL ifd = IOCcotainer.CreateFKDAO();
        public int FKDel(config_file_first_kindModel st)
        {
            return ifd.FKDel(st);
        }

        public List<config_file_first_kindModel> FKSelect()
        {
            return ifd.FKSelect();
        }

        public int FKtAdd(config_file_first_kindModel st)
        {
            return ifd.FKtAdd(st);
        }

        public int FKUpdate(config_file_first_kindModel st)
        {
            return ifd.FKUpdate(st);
        }

        public List<config_file_first_kindModel> SelectBy(config_file_first_kindModel st)
        {
            return ifd.SelectBy(st);
        }
    }
}
