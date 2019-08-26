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
    public class public_charController : Controller
    {
        Ipublic_charBLL icb = IOCcotainer.Createpublic_charBLL();
        // GET: public_char
        public ActionResult Index()
        {
            List<public_charModel> list = icb.PCAll();
            return View(list);
        }

        // GET: public_char/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: public_char/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection,public_charModel pcm)
        {
            int result = icb.PCAdd(pcm);
            if (result>0)
            {
                return Content("<script>alert('新增成功哦');window.location.href='/public_char/Index'</script>");
            }
            else
            {
                return View();
            }
        }

        // GET: public_char/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: public_char/Edit/5
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
        // POST: public_char/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            public_charModel pc = new public_charModel()
            {
                pbc_id = id
            };
            int result = icb.PCDelete(pc);
            if (result>0)
            {
                return Content("<script>alert('删除成功哦');window.location.href='/public_char/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败哦');window.location.href='/public_char/Index'</script>");
            }
        }
    }
}
