using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IHRBLL;
using IOC;
using Model;
using System.Data;

namespace HR.Controllers
{
    public class majorController : Controller
    {
        Iconfig_major_kindBLL icmkb = IOCcotainer.Createconfig_major_kindBLL();
        Iconfig_majorBLL icmb = IOCcotainer.Createconfig_majorBLL();
        // GET: major
        public ActionResult Index()
        {
            List<config_majorModel> list = icmb.Select();
            return View(list);
        }

        [HttpGet]
        // GET: major/Create
        public ActionResult Add()
        {
            DropList();
            return View();
        }

        private void DropList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            DataTable dt = icmkb.SelectType();
            foreach (DataRow dr in dt.Rows)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = dr["major_kind_name"].ToString(),
                    Value = dr["major_kind_id"].ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt = list;
        }
        
        [HttpPost]
        public ActionResult Add(config_majorModel cm)
        {
            if (ModelState.IsValid)//后台验证
            {
                string id = cm.major_kind_id;
                string name = icmkb.SelectById(id);
                config_majorModel cmm = new config_majorModel
                {
                    major_kind_id = cm.major_kind_id,
                    major_kind_name = name,
                    major_id = cm.major_id,
                    major_name = cm.major_name,
                    test_amount = 0
                };
                if (icmb.Add(cmm) > 0)
                {
                    return Content("<script>alert('新增成功!');window.location.href ='/major/Index';</script>");
                }
                else
                {
                    return Content("<script>alert('新增失败!');window.location.href ='/major/Add';</script>");
                }
            }
            else
            {
                return View(cm);
            }
        }

        // GET: major/Delete/5
        public ActionResult Delete(int id)
        {
            config_majorModel cfm = new config_majorModel()
            {
                mak_id=id
            };
            if (icmb.Del(cfm) > 0)
            {
                return Content("<script>alert('删除成功!');window.location.href ='/major/Index';</script>");
            }
            else
            {
                return Content("<script>alert('删除失败!');window.location.href ='/major/Index';</script>");
            }
        }
    }
}
