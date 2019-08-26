using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IHRBLL;
using IOC;

namespace HR.Controllers
{
    public class ClientController : Controller
    {
        IFirstKindBLL ifb = IOCcotainer.CreateFKBLL();
        public ActionResult Index()
        {
            List<config_file_first_kindModel> list = ifb.FKSelect();
            return View(list);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();

        }

        //
        // POST: /Studente/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection, config_file_first_kindModel s)
        {
            if (ifb.FKtAdd(s) > 0)
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
            config_file_first_kindModel sm = new config_file_first_kindModel()
            {
                ffk_id = id
            };
            List<config_file_first_kindModel> list = ifb.SelectBy(sm);
            config_file_first_kindModel st = new config_file_first_kindModel
            {
                ffk_id = list[0].ffk_id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                first_kind_salary_id = list[0].first_kind_salary_id,
                first_kind_sale_id = list[0].first_kind_sale_id
            };
            return View(st);
        }

        //
        // POST: /Studente/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, config_file_first_kindModel s)
        {
            if (ifb.FKUpdate(s) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.dt = s;
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            config_file_first_kindModel sm = new config_file_first_kindModel()
            {
                ffk_id = id
            };
            int result = ifb.FKDel(sm);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
    }
}