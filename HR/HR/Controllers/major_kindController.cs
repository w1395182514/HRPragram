using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
using IHRBLL;
using Model;
using Newtonsoft.Json;

namespace HR.Controllers
{
    public class major_kindController : Controller
    {
        Iconfig_major_kindBLL icmkd = IOCcotainer.Createconfig_major_kindBLL();
        // GET: major_kind
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sel()
        {
            List<config_major_kindModel> list = icmkd.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(config_major_kindModel cm)
        {
            if (ModelState.IsValid)//后台验证
            {
                int result = Convert.ToInt32(icmkd.MaxId());
                config_major_kindModel cmk = new config_major_kindModel()
                {
                    major_kind_id = (result + 1).ToString(),
                    major_kind_name = cm.major_kind_name
                };
                if (icmkd.Add(cmk) > 0)
                {
                    return Content("<script>alert('新增成功!');window.location.href ='/major_kind/Index';</script>");
                }
                else
                {
                    return Content("<script>alert('新增失败!');window.location.href ='/major_kind/Add';</script>");
                }
            }
            else
            {
                return View(cm);
            }
        }

        public ActionResult Delete(int id)
        {
            config_major_kindModel cmk = new config_major_kindModel()
            {
                mfk_id=id
            };
            if (icmkd.Del(cmk) > 0)
            {
                return Content("ok");
            }
            else
            {
                return Content("nook");
            }
        }
    }
}
