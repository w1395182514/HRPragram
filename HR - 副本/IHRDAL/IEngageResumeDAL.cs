using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace IHRDAL
{
    public interface IEngageResumeDAL
    {
        int TKtAdd(engage_resumeModel st);

        int TKDel(engage_resumeModel st);

        List<engage_resumeModel> TKSelect();

        int TKUpdate(engage_resumeModel st);

        List<engage_resumeModel> SelectBy(engage_resumeModel st);

        DataTable SelectType();

        DataTable SelectType2(int id);
    }
}
