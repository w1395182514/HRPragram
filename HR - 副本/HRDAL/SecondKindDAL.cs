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
    public class SecondKindDAL:DaoBase<config_file_second_kind>,ISecondKindDAL
    {
        public int SKtAdd(config_file_second_kindModel st)
        {
            config_file_second_kind est = new config_file_second_kind()
            {
                fsk_id = st.fsk_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                second_salary_id = st.second_salary_id,
                second_sale_id = st.second_sale_id
            };
            return Add(est);
        }

        public int SKDel(config_file_second_kindModel st)
        {
            config_file_second_kind est = new config_file_second_kind()
            {
                fsk_id = st.fsk_id,
            };
            return Delete(est);
        }

        public List<config_file_second_kindModel> SKSelect()
        {
            List<config_file_second_kind> list = SelectAll();
            List<config_file_second_kindModel> list2 = new List<config_file_second_kindModel>();
            foreach (config_file_second_kind item in list)
            {
                config_file_second_kindModel sm = new config_file_second_kindModel()
                {
                    fsk_id = item.fsk_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    second_salary_id = item.second_salary_id,
                    second_sale_id = item.second_sale_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int SKUpdate(config_file_second_kindModel st)
        {
            config_file_second_kind est = new config_file_second_kind()
            {
                fsk_id = st.fsk_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                second_sale_id = st.second_sale_id,
                second_salary_id = st.second_salary_id
            };
            return Update(est);
        }

        public List<config_file_second_kindModel> SelectBy(config_file_second_kindModel st)
        {
            List<config_file_second_kind> list = SelectBy(e => e.fsk_id.Equals(st.fsk_id));
            List<config_file_second_kindModel> list2 = new List<config_file_second_kindModel>();
            foreach (config_file_second_kind item in list)
            {
                config_file_second_kindModel sm = new config_file_second_kindModel()
                {
                    fsk_id = list[0].fsk_id,
                    first_kind_id = list[0].first_kind_id,
                    first_kind_name = list[0].first_kind_name,
                    second_kind_id = list[0].second_kind_id,
                    second_salary_id = list[0].second_salary_id,
                    second_kind_name = list[0].second_kind_name,
                    second_sale_id = list[0].second_sale_id,
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
        
    }
}
