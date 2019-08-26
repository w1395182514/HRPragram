using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHRDAL;
using Model;
using EFentity;
using System.Runtime.Remoting.Messaging;
using System.Data.Entity.Infrastructure;
using System.Data;

namespace HRDAL
{
    public class config_major_kindDAL :DaoBase<config_major_kind>, Iconfig_major_kindDAL
    {
        static MyDbcontext db = CreateDbContext();

        //用于监测Context中的Entity是否存在，如果存在，将其Detach，防止出现问题。
        private Boolean RemoveHoldingEntityInContext(config_major_kind entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<config_major_kind>();
            var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);

            Object foundEntity;
            var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

            if (exists)
            {
                objContext.Detach(foundEntity);
            }

            return (exists);
        }

        private static MyDbcontext CreateDbContext()
        {
            //从当前请求的线程取值
            db = CallContext.GetData("s") as MyDbcontext;
            if (db == null)
            {
                db = new MyDbcontext();
                //把上下文对象存入当前请求的线程中
                CallContext.SetData("s", db);
            }
            return db;
        }

        public int Add(config_major_kindModel cm)
        {
            config_major_kind cmk = new config_major_kind()
            {
                mfk_id=cm.mfk_id,
                major_kind_id=cm.major_kind_id,
                major_kind_name=cm.major_kind_name
            };
            return Add(cmk);
        }

        public int Del(config_major_kindModel cm)
        {
            config_major_kind cmk = new config_major_kind()
            {
                mfk_id=cm.mfk_id
            };
            return Delete(cmk);
        }

        public object MaxId()
        {
            var result = Convert.ToInt32(db.config_major_kinds.Select(e => e.major_kind_id).Max());
            return result;
        }

        public List<config_major_kindModel> Select()
        {
            List<config_major_kind> list = SelectAll();
            List<config_major_kindModel> list2 = new List<config_major_kindModel>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel cmk = new config_major_kindModel()
                {
                    mfk_id = item.mfk_id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name
                };
                list2.Add(cmk);
            }
            return list2;
        }

        public List<config_major_kindModel> SelectBy(config_major_kindModel cm)
        {
            List<config_major_kind> list = SelectBy(e=>e.mfk_id.Equals(cm.mfk_id));
            List<config_major_kindModel> list2 = new List<config_major_kindModel>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel cmk = new config_major_kindModel()
                {
                    mfk_id = item.mfk_id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name
                };
                list2.Add(cmk);
            }
            return list2;
        }

        public int Update(config_major_kindModel cm)
        {
            config_major_kind cmk = new config_major_kind()
            {
                mfk_id = cm.mfk_id,
                major_kind_id = cm.major_kind_id,
                major_kind_name = cm.major_kind_name
            };
            return Update(cmk);
        }

        public DataTable SelectType()
        {
            string sql = "select major_kind_id, major_kind_name from [dbo].[config_major_kind]";
            return DBHelper.SelectTable(sql);
        }

        public string SelectById(object id)
        {
            string sql = string.Format("select major_kind_name from [dbo].[config_major_kind] where [major_kind_id] ='{0}'",id);
            return DBHelper.SelectSinger(sql).ToString();
        }
    }
}
