using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IHRDAL;
using EFentity;

namespace HRDAL
{
    public class public_charDAL : DaoBase<config_public_char>, Ipublic_charDAL
    {
        public int PCAdd(public_charModel t)
        {
            config_public_char cp = new config_public_char()
            {
                 attribute_kind=t.attribute_kind,
                  attribute_name=t.attribute_name
            };
            return Add(cp);
        }

        //显示全部
        public List<public_charModel> PCAll()
        {
            List<config_public_char> list = SelectAll();
            List<public_charModel> list2 = new List<public_charModel>();
            foreach (config_public_char item in list)
            {
                public_charModel pc = new public_charModel()
                {
                      pbc_id=item.pbc_id,
                       attribute_name=item.attribute_name,
                        attribute_kind=item.attribute_kind
                };
                list2.Add(pc);
            }
            return list2;
        }

        public int PCDelete(public_charModel t)
        {
            config_public_char cp = new config_public_char()
            {
                pbc_id = t.pbc_id
            };
            return Delete(cp);
        }

        public int SPCAdd(public_charModel t)
        {
            config_public_char cp = new config_public_char()
            {
                attribute_kind = t.attribute_kind,
                attribute_name = t.attribute_name
            };
            return Add(cp);
        }

        public int SPCDelete(public_charModel t)
        {
            config_public_char cp = new config_public_char()
            {
                 pbc_id=t.pbc_id
            };
            return Delete(cp);
        }

        public List<public_charModel> SPCSelectBy(public_charModel st)
        {
            List<config_public_char> list = SelectBy(e => e.attribute_kind.Equals(st.attribute_kind));
            List<public_charModel> list2 = new List<public_charModel>();
            foreach (config_public_char item in list)
            {
                public_charModel sm = new public_charModel()
                {
                      pbc_id=item.pbc_id,
                     attribute_name=item.attribute_name,
                     attribute_kind=item.attribute_kind
                };
                list2.Add(sm);

            }
            return list2;
        }
    }
}
