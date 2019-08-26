using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IHRBLL;
using IOC;
using Newtonsoft.Json;
using System.Data;

namespace HR.Controllers
{
    public class ClientSecondController : Controller
    {
        // GET: ClientSecond
        ISecondKindBLL isb = IOCcotainer.CreateSKBLL();
        public ActionResult Index()
        {
            List<config_file_second_kindModel> list = isb.SKSelect();
            return View(list);
        }
        private void DropList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            DataTable dt = isb.SelctType();
            foreach (DataRow dr in dt.Rows)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = dr["first_kind_name"].ToString(),
                    Value = dr["first_kind_id"].ToString()

                };
                list.Add(sl);
            }
            ViewBag.dt = list;
        }
        public ActionResult DorpList()
        {
            DataTable dt = isb.SelctType();
            return Content(JsonConvert.SerializeObject(dt));

        }
        [HttpGet]
        public ActionResult Create()
        {
            DropList();
            return View();

        }

        //
        // POST: /Studente/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection, config_file_second_kindModel s)
        {
            DataTable dt = isb.SelectByID(s.first_kind_id.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                s.first_kind_name = dr["first_kind_name"].ToString();
            }
            if (isb.SKtAdd(s) > 0)
            {
                return Redirect("Index");
            }
            else
            {
                DropList();
                return View(s);
            }
        }

        public ActionResult Delete(int id)
        {
            config_file_second_kindModel sm = new config_file_second_kindModel()
            {
                fsk_id = id
            };
            int result = isb.SKDel(sm);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            config_file_second_kindModel sm = new config_file_second_kindModel()
            {
                fsk_id = id
            };
            List<config_file_second_kindModel> list = isb.SelectBy(sm);
            config_file_second_kindModel st = new config_file_second_kindModel()
            {
                fsk_id = list[0].fsk_id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                second_salary_id = list[0].second_salary_id,
                second_sale_id = list[0].second_sale_id
            };
            return View(st);
        }

        //
        // POST: /Studente/Edit/5

        [HttpPost]
        public ActionResult Edit( int id,FormCollection collection, config_file_second_kindModel s)
        {
            if (isb.SKUpdate(s) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.dt = s;
                return View();
            }
        }
    }
}