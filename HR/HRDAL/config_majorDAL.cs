using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHRDAL;
using EFentity;
using Model;

namespace HRDAL
{
    public class config_majorDAL : DaoBase<config_major>, Iconfig_majorDAL
    {
        public int Add(config_majorModel cm)
        {
            config_major cfm = new config_major()
            {
                mak_id=cm.mak_id,
                major_kind_id=cm.major_kind_id,
                major_kind_name=cm.major_kind_name,
                major_id=cm.major_id,
                major_name=cm.major_name,
                test_amount=cm.test_amount
            };
            return Add(cfm);
        }

        public int Del(config_majorModel cm)
        {
            config_major cfm = new config_major()
            {
                mak_id = cm.mak_id
            };
            return Delete(cfm);
        }

        public List<config_majorModel> Select()
        {
            List<config_major> list = SelectAll();
            List<config_majorModel> list2 = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel cfm = new config_majorModel()
                {
                    mak_id = item.mak_id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name,
                    test_amount = item.test_amount
                };
                list2.Add(cfm);
            }
            return list2;
        }

        public List<config_majorModel> SelectBy(config_majorModel cm)
        {
            List<config_major> list = SelectBy(e => e.mak_id.Equals(cm.mak_id));
            List<config_majorModel> list2 = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel cfm = new config_majorModel()
                {
                    mak_id = item.mak_id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name,
                    test_amount = item.test_amount
                };
                list2.Add(cfm);
            }
            return list2;
        }

        public int Update(config_majorModel cm)
        {
            config_major cfm = new config_major()
            {
                mak_id = cm.mak_id,
                major_kind_id = cm.major_kind_id,
                major_kind_name = cm.major_kind_name,
                major_id = cm.major_id,
                major_name = cm.major_name,
                test_amount = cm.test_amount
            };
            return Update(cfm);
        }
    }
}
