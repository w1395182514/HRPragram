using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHRDAL;
using EFentity;
using Model;
using System.Data;

namespace HRDAL
{
    public class major_changeDAL : DaoBase<major_change>, Imajor_changeDAL
    {
        //查询I级机构名称绑定下拉框
        public DataTable CX1()
        {
            string sql = string.Format("select [ffk_id],[first_kind_name] from [dbo].[config_file_first_kind]");
            return DBHelper.SelectTable(sql);
        }
        //查询II级机构名称绑定下拉框
        public DataTable CX2()
        {
            string sql = string.Format("select [fsk_id],second_kind_name  from [dbo].[config_file_second_kind]");
            return DBHelper.SelectTable(sql);
        }
    }
}
