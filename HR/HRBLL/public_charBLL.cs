using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHRBLL;
using IOC;
using IHRDAL;
using Model;

namespace HRBLL
{
    public class public_charBLL : Ipublic_charBLL
    {
        Ipublic_charDAL ic = IOCcotainer.Createpublic_charDAO();

        public int PCAdd(public_charModel t)
        {
            return ic.PCAdd(t);
        }

        public List<public_charModel> PCAll()
        {
            return ic.PCAll();
        }

        public int PCDelete(public_charModel t)
        {
            return ic.PCDelete(t);
        }

        public int SPCAdd(public_charModel t)
        {
            return ic.SPCAdd(t);
        }

        public int SPCDelete(public_charModel t)
        {
            return ic.SPCDelete(t);
        }

        public List<public_charModel> SPCSelectBy(public_charModel st)
        {
            return ic.SPCSelectBy(st);
        }
    }
}
