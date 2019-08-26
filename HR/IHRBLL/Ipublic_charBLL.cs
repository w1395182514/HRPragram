using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IHRBLL
{
   public interface Ipublic_charBLL
    {
        //public_char页面的新增/删除
        List<public_charModel> PCAll();

        int PCAdd(public_charModel t);

        int PCDelete(public_charModel t);

        //salary_item页面的新增/删除

        List<public_charModel> SPCSelectBy(public_charModel st);

        int SPCDelete(public_charModel t);
        int SPCAdd(public_charModel t);
    }
}
