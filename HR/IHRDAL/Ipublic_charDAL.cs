using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IHRDAL
{
   public interface Ipublic_charDAL
    {
        List<public_charModel> PCAll();

        int PCAdd(public_charModel t);

        int PCDelete(public_charModel t);



        List<public_charModel> SPCSelectBy(public_charModel st);

        int SPCAdd(public_charModel t);

        int SPCDelete(public_charModel t);
    }
}
