using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRBLL
{
    public interface ISecondKindBLL
    {
        int SKtAdd(config_file_second_kindModel st);

        int SKDel(config_file_second_kindModel st);

        List<config_file_second_kindModel> SKSelect();

        int SKUpdate(config_file_second_kindModel st);

        List<config_file_second_kindModel> SelectBy(config_file_second_kindModel st);

        DataTable SelctType();

        DataTable SelectByID(string id);
    }
}
