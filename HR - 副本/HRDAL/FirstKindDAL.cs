using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFentity;
using IHRDAL;

namespace HRDAL
{
    public class FirstKindDAL:DaoBase<config_file_first_kind>, IFirstKindDAL
    {
        public int FKtAdd(config_file_first_kindModel st)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                ffk_id = st.ffk_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                first_kind_salary_id = st.first_kind_salary_id,
                first_kind_sale_id = st.first_kind_sale_id
            };
            return Add(est);
        }

        public int FKDel(config_file_first_kindModel st)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                ffk_id = st.ffk_id,
            };
            return Delete(est);
        }

        public List<config_file_first_kindModel> FKSelect()
        {
            List<config_file_first_kind> list = SelectAll();
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel sm = new config_file_first_kindModel()
                {
                   ffk_id = item.ffk_id,
                   first_kind_id = item.first_kind_id,
                   first_kind_name = item.first_kind_name,
                   first_kind_sale_id = item.first_kind_sale_id,
                   first_kind_salary_id = item.first_kind_salary_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int FKUpdate(config_file_first_kindModel st)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                ffk_id = st.ffk_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                first_kind_salary_id = st.first_kind_salary_id,
                first_kind_sale_id = st.first_kind_sale_id
            };
            return Update(est);
        }

        public List<config_file_first_kindModel> SelectBy(config_file_first_kindModel st)
        {
            List<config_file_first_kind> list = SelectBy(e => e.ffk_id.Equals(st.ffk_id));
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel sm = new config_file_first_kindModel()
                {
                    ffk_id = item.ffk_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id
                };
                list2.Add(sm);
            }
            return list2;
        }
    }
}
