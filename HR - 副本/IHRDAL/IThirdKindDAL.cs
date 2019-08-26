using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRDAL
{
    public interface IThirdKindDAL
    {
        int TKtAdd(config_file_third_kindModel st);

        int TKDel(config_file_third_kindModel st);

        List<config_file_third_kindModel> TKSelect();

        int TKUpdate(config_file_third_kindModel st);

        List<config_file_third_kindModel> TelectBy(config_file_third_kindModel st);

        DataTable SelctType();

        DataTable SelectByID(string id);

        DataTable SelectSecondType();

        DataTable SelectSecondByID(string id);
    }
}
