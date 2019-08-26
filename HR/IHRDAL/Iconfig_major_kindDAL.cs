using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRDAL
{
    public interface Iconfig_major_kindDAL
    {
        int Add(config_major_kindModel cm);
        int Del(config_major_kindModel cm);
        int Update(config_major_kindModel cm);
        List<config_major_kindModel> Select();
        List<config_major_kindModel> SelectBy(config_major_kindModel cm);
        Object MaxId();
        DataTable SelectType();
        string SelectById(object id);
    }
}
