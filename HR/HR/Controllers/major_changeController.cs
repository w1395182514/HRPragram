using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
using IHRBLL;
using Model;

namespace HR.Controllers
{
    public class major_changeController : Controller
    {

        Imajor_changeBLL imd = IOCcotainer.Createmajor_changeBLL();
        // GET: major_change
        public ActionResult Index()
        {
            Fi1();
            Fi2();
            return View();
        }

        // GET: major_change/Create
        public ActionResult Create()
        {
            return View();
        }
        //查询I级机构名称绑定下拉框
        private void Fi1()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            DataTable dt = imd.CX1();
            foreach (DataRow dr in dt.Rows)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = dr["first_kind_name"].ToString(),
                    Value = dr["ffk_id"].ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt = list;
        }
        //查询II级机构名称绑定下拉框
        private void Fi2()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            DataTable dt = imd.CX2();
            foreach (DataRow dr in dt.Rows)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = dr["second_kind_name"].ToString(),
                    Value = dr["fsk_id"].ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt = list;
        }




        // POST: major_change/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: major_change/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: major_change/Edit/5
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

        // GET: major_change/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: major_change/Delete/5
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
