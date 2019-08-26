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
    public class salary_itemController : Controller
    {
        Ipublic_charBLL ic = IOCcotainer.Createpublic_charBLL();
        // GET: salary_item
        public ActionResult Index()
        {
            public_charModel pm = new public_charModel()
            {
                attribute_kind="薪酬设置"
            };
            List<public_charModel> list = ic.SPCSelectBy(pm);
            List<public_charModel> list2 = new List<public_charModel>();
            foreach (var item in list)
            {
                public_charModel pm2 = new public_charModel()
                {
                     pbc_id=item.pbc_id,
                      attribute_kind=item.attribute_kind,
                       attribute_name=item.attribute_name
                };
                list2.Add(pm2);
            }
            return View(list2);
        }

        // GET: salary_item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: salary_item/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection,public_charModel cpm)
        {
            int result = ic.SPCAdd(cpm);
            if (result>0)
            {
                return Content("<script>alert('新增成功');window.location.href='/salary_item/Index'</script>");
                
            }
            else
            {
                return View();
            }
        }

        // GET: salary_item/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: salary_item/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: salary_item/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            public_charModel cp = new public_charModel()
            {
                pbc_id = id
            };
            int result = ic.SPCDelete(cp);
            if (result>0)
            {
                return Content("<script>alert('删除成功');window.location.href='/salary_item/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/salary_item/Index'</script>");
            }
        }
    }
}
