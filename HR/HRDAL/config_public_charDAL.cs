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
    public class config_public_charDAL : DaoBase<config_public_char>, Iconfig_public_charDAL
    {
        public int Add(config_public_charModel cm)
        {
            config_public_char cpc = new config_public_char()
            {
                pbc_id=cm.pbc_id,
                attribute_kind=cm.attribute_kind,
                attribute_name=cm.attribute_name
            };
            return Add(cpc);
        }

        public int Del(config_public_charModel cm)
        {
            config_public_char cpc = new config_public_char()
            {
                pbc_id = cm.pbc_id
            };
            return Delete(cpc);
        }

        public List<config_public_charModel> Select()
        {
            List<config_public_char> list = SelectAll();
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel cpc = new config_public_charModel()
                {
                    pbc_id = item.pbc_id,
                    attribute_kind = item.attribute_kind,
                    attribute_name = item.attribute_name
                };
                list2.Add(cpc);
            }
            return list2;
        }

        public List<config_public_charModel> SelectBy(config_public_charModel cm)
        {
            List<config_public_char> list = SelectBy(e => e.attribute_kind.Equals(cm.attribute_kind));
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel cpc = new config_public_charModel()
                {
                    pbc_id = item.pbc_id,
                    attribute_kind = item.attribute_kind,
                    attribute_name = item.attribute_name
                };
                list2.Add(cpc);
            }
            return list2;
        }

        public int Update(config_public_charModel cm)
        {
            config_public_char cpc = new config_public_char()
            {
                pbc_id = cm.pbc_id,
                attribute_kind = cm.attribute_kind,
                attribute_name = cm.attribute_name
            };
            return Update(cpc);
        }
    }
}
