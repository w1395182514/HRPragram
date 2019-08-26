using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFentity;
using IHRDAL;
using System.Data;

namespace HRDAL
{
    public class ThirdKindDAL:DaoBase<config_file_third_kind>,IThirdKindDAL
    {
        public int TKtAdd(config_file_third_kindModel st)
        {
            config_file_third_kind est = new config_file_third_kind()
            {
                ftk_id = st.ftk_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_is_retail = st.third_kind_is_retail,
                third_kind_name = st.third_kind_name,
                third_kind_sale_id = st.third_kind_sale_id
            };
            return Add(est);
        }

        public int TKDel(config_file_third_kindModel st)
        {
            config_file_third_kind est = new config_file_third_kind()
            {
                ftk_id = st.ftk_id,
            };
            return Delete(est);
        }

        public List<config_file_third_kindModel> TKSelect()
        {
            List<config_file_third_kind> list = SelectAll();
            List<config_file_third_kindModel> list2 = new List<config_file_third_kindModel>();
            foreach (config_file_third_kind item in list)
            {
                config_file_third_kindModel sm = new config_file_third_kindModel()
                {
                    ftk_id = item.ftk_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_is_retail = item.third_kind_is_retail,
                    third_kind_name = item.third_kind_name,
                    third_kind_sale_id = item.third_kind_sale_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int TKUpdate(config_file_third_kindModel st)
        {
            config_file_third_kind est = new config_file_third_kind()
            {
                ftk_id = st.ftk_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_is_retail = st.third_kind_is_retail,
                third_kind_name = st.third_kind_name,
                third_kind_sale_id = st.third_kind_sale_id
            };
            return Update(est);
        }

        public List<config_file_third_kindModel> TelectBy(config_file_third_kindModel st)
        {
            List<config_file_third_kind> list = SelectBy(e => e.ftk_id.Equals(st.ftk_id));
            List<config_file_third_kindModel> list2 = new List<config_file_third_kindModel>();
            foreach (config_file_third_kind item in list)
            {
                config_file_third_kindModel sm = new config_file_third_kindModel()
                {
                    ftk_id = list[0].ftk_id,
                    first_kind_id = list[0].first_kind_id,
                    first_kind_name = list[0].first_kind_name,
                    second_kind_id = list[0].second_kind_id,
                    second_kind_name = list[0].second_kind_name,
                    third_kind_id = list[0].third_kind_id,
                    third_kind_is_retail = list[0].third_kind_is_retail,
                    third_kind_name = list[0].third_kind_name,
                    third_kind_sale_id = list[0].third_kind_sale_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public DataTable SelctType()
        {
            string sql = "select first_kind_id,first_kind_name from config_file_first_kind";
            return DBHelper.SelectTable(sql);
        }

        public DataTable SelectByID(string id)
        {
            string sql = $"select first_kind_id,first_kind_name from config_file_first_kind where first_kind_id = {id}";
            return DBHelper.SelectTable(sql);
        }

        public DataTable SelectSecondType()
        {
            string sql = "select [second_kind_id],[second_kind_name] from [dbo].[config_file_second_kind]";
            return DBHelper.SelectTable(sql);
        }

        public DataTable SelectSecondByID(string  id)
        {
            string sql = $"select [second_kind_id],[second_kind_name] from [dbo].[config_file_second_kind] where [second_kind_id]={id}";
            return DBHelper.SelectTable(sql);
        }

      
    }
}
