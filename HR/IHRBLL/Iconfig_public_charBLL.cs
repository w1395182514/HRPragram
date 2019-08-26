using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRBLL
{
    public interface Iconfig_public_charBLL
    {
        int Add(config_public_charModel cm);
        int Del(config_public_charModel cm);
        int Update(config_public_charModel cm);
        List<config_public_charModel> Select();
        List<config_public_charModel> SelectBy(config_public_charModel cm);
    }
}
