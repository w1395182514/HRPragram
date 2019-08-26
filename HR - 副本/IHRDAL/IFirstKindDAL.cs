using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRDAL
{
    public interface IFirstKindDAL
    {
        int FKtAdd(config_file_first_kindModel st);

        int FKDel(config_file_first_kindModel st);

        List<config_file_first_kindModel> FKSelect();

        int FKUpdate(config_file_first_kindModel st);

        List<config_file_first_kindModel> SelectBy(config_file_first_kindModel st);
    }
}
