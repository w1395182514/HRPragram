using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHRBLL;
using Model;
using IOC;
using IHRDAL;

namespace HRBLL
{
    public class ThirdKindBLL : IThirdKindBLL
    {
        IThirdKindDAL itd = IOCcotainer.CreateTKDAO();
        public DataTable SelctType()
        {
            return itd.SelctType();
        }

        public DataTable SelectByID(string id)
        {
            return itd.SelectByID(id);
        }

        public DataTable SelectSecondByID(string id)
        {
            return itd.SelectSecondByID(id);
        }

        public DataTable SelectSecondType()
        {
            return itd.SelectSecondType();
        }

        public List<config_file_third_kindModel> TelectBy(config_file_third_kindModel st)
        {
            return itd.TelectBy(st);
        }

        public int TKDel(config_file_third_kindModel st)
        {
            return itd.TKDel(st);
        }

        public List<config_file_third_kindModel> TKSelect()
        {
            return itd.TKSelect();
        }

        public int TKtAdd(config_file_third_kindModel st)
        {
            return itd.TKtAdd(st);
        }

        public int TKUpdate(config_file_third_kindModel st)
        {
            return itd.TKUpdate(st);
        }
    }
}
