using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
using IHRBLL;
using Model;
using Newtonsoft.Json;
using System.Data;

namespace HR.Controllers
{
    public class file_third_kindController : Controller
    {
        Iconfig_file_third_kindBLL ift = IOCcotainer.Createconfig_file_third_kindBLL();
        // GET: file_third_kind

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RenStr()
        {
            List<config_file_third_kindModel> list = ift.FTKAll();
            return Content(JsonConvert.SerializeObject(list));
        }
        // GET: file_third_kind/Create
        public ActionResult Create()
        {
            Fi1();
            Fi2();
            return View();
        }

        // POST: file_third_kind/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection,config_file_third_kindModel ftk)
        {
            if (ModelState.IsValid)//后台验证
            {
                int result = ift.FTAdd(ftk);
            if (result > 0)
            {
                return Content("<script>alert('新增成功哦');window.location.href='/public_char/Index'</script>");
            }
            else
            {
                    
                    return Content("<script>alert('新增失败哦');window.location.href='/public_char/Create'</script>");
             }

            }
            else
            {
                return View();
            }
                
        }

        //查询I级机构名称绑定下拉框
        private void Fi1()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            DataTable dt = ift.CX1();
            foreach (DataRow dr in dt.Rows)
            {
                SelectListItem sl = new SelectListItem()
                {
                     Text=dr["first_kind_name"].ToString(),
                      Value=dr["ffk_id"].ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt = list;
        }
        //查询II级机构名称绑定下拉框
        private void Fi2()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            DataTable dt = ift.CX2();
            foreach (DataRow dr in dt.Rows)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = dr["second_kind_name"].ToString(),
                    Value = dr["fsk_id"].ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt1 = list;
        }
        // GET: file_third_kind/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: file_third_kind/Edit/5
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

        // GET: file_third_kind/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: file_third_kind/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
