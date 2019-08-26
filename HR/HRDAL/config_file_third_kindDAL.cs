using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHRDAL;
using Model;
using EFentity;
using System.Data;

namespace HRDAL
{
    public class config_file_third_kindDAL : DaoBase<config_file_third_kind>, Iconfig_file_third_kindDAL
    {
        public List<config_file_third_kindModel> FTKAll()
        {
            List<config_file_third_kind> list = SelectAll();
            List<config_file_third_kindModel> list2 = new List<config_file_third_kindModel>();
            foreach (config_file_third_kind item in list)
            {
                config_file_third_kindModel ftk = new config_file_third_kindModel()
                {
                     ftk_id=item.ftk_id,
                    first_kind_id=item.first_kind_id,
                    first_kind_name=item.first_kind_name,
                    second_kind_id=item.second_kind_id,
                    second_kind_name=item.second_kind_name,
                    third_kind_id=item.third_kind_id,
                    third_kind_name=item.third_kind_name,
                    third_kind_sale_id=item.third_kind_sale_id,
                    third_kind_is_retail=item.third_kind_is_retail
                };
                list2.Add(ftk);
            }
            return list2;
            
        }

        public int FTAdd(config_file_third_kindModel t)
        {
            config_file_third_kind fkt = new config_file_third_kind()
            {
                first_kind_id = t.first_kind_id,
                first_kind_name = t.first_kind_name,
                second_kind_id = t.second_kind_id,
                second_kind_name = t.second_kind_name,
                third_kind_id = t.third_kind_id,
                third_kind_name = t.third_kind_name,
                third_kind_sale_id = t.third_kind_sale_id,
                third_kind_is_retail = t.third_kind_is_retail
            };
            return Add(fkt);
        }

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
