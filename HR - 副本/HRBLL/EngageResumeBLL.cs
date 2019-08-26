using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC;
using IHRBLL;
using IHRDAL;
using Model;
using System.Data;

namespace HRBLL
{
    public class EngageResumeBLL : IEngageResumeBLL
    {
        IEngageResumeDAL ied = IOCcotainer.CreateERDAO();
        public List<engage_resumeModel> SelectBy(engage_resumeModel st)
        {
            return ied.SelectBy(st);
        }

        public DataTable SelectType()
        {
            return ied.SelectType();
        }

        public DataTable SelectType2(int id)
        {
            return ied.SelectType2(id);
        }

        public int TKDel(engage_resumeModel st)
        {
            return ied.TKDel(st);
        }

        public List<engage_resumeModel> TKSelect()
        {
            return ied.TKSelect();
        }

        public int TKtAdd(engage_resumeModel st)
        {
            return ied.TKtAdd(st);
        }

        public int TKUpdate(engage_resumeModel st)
        {
            return ied.TKUpdate(st);
        }
    }
}
