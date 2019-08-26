using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHRDAL;
using IHRBLL;
using IOC;
using Model;
using System.Data;

namespace HRBLL
{
    public class SecondKindBLL : ISecondKindBLL
    {
        ISecondKindDAL isd = IOCcotainer.CreateSKDAO();

        public DataTable SelctType()
        {
            return isd.SelctType();
        }

        public List<config_file_second_kindModel> SelectBy(config_file_second_kindModel st)
        {
            return isd.SelectBy(st);
        }

        public DataTable SelectByID(string id)
        {
            return isd.SelectByID(id);
        }

        public int SKDel(config_file_second_kindModel st)
        {
            return isd.SKDel(st);
        }

        public List<config_file_second_kindModel> SKSelect()
        {
            return isd.SKSelect();
        }

        public int SKtAdd(config_file_second_kindModel st)
        {
            return isd.SKtAdd(st);
        }

        public int SKUpdate(config_file_second_kindModel st)
        {
            return isd.SKUpdate(st);
        }
    }
}
