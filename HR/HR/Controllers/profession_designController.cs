using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IHRBLL;
using IOC;
using Model;

namespace HR.Controllers
{
    public class profession_designController : Controller
    {
        Iconfig_public_charBLL icpcb = IOCcotainer.Createconfig_public_charBLL();
        // GET: config_public_char
        public ActionResult Index()
        { 
            config_public_charModel cpm = new config_public_charModel()
            {
                attribute_kind = "职称"
            };
            List<config_public_charModel> list = icpcb.SelectBy(cpm);
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_charModel item in list)
            {
                config_public_charModel cpc = new config_public_charModel()
                {
                    pbc_id = item.pbc_id,
                    attribute_kind = item.attribute_kind,
                    attribute_name = item.attribute_name
                };
                list2.Add(cpc);
            }
            return View(list2);
        }

        // GET: config_public_char/Delete/5
        public ActionResult Delete(int id)
        {
            config_public_charModel cpm = new config_public_charModel()
            {
                pbc_id=id
            };
            if (icpcb.Del(cpm) > 0)
            {
                return Content("<script>alert('删除成功!');window.location.href ='/profession_design/Index';</script>");
            }
            else
            {
                return Content("<script>alert('删除失败!');window.location.href ='/profession_design/Index';</script>");
            }
        }
    }
}
