using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IHRBLL;
using IOC;
using System.Data;

namespace HR.Controllers
{
    public class ClientThirdController : Controller
    {
        // GET: ClientThird
        IThirdKindBLL itb = IOCcotainer.CreateTKBLL();
        public ActionResult Index()
        {
            List<config_file_third_kindModel> list = itb.TKSelect();
            return View(list);
        }
        private void DropList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            DataTable dt = itb.SelctType();
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

        private void DropList2()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            DataTable dt = itb.SelectSecondType();
            foreach (DataRow dr in dt.Rows)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = dr["second_kind_name"].ToString(),
                    Value = dr["second_kind_id"].ToString()

                };
                list.Add(sl);
            }
            ViewBag.dr = list;
        }

        private void DropList3()
        {
            List<SelectListItem> list = new List<SelectListItem>
            {
                new SelectListItem {Text="是",Value="1",Selected=true },
                new SelectListItem {Text="否",Value="2",Selected=true  }
            };
            ViewBag.dy = list;
        }

        [HttpGet]
        public ActionResult Create()
        {
            DropList();
            DropList2();
            DropList3();
            return View();

        }

        //
        // POST: /Studente/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection, config_file_third_kindModel s)
        {
            DataTable dt = itb.SelectByID(s.first_kind_id.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                s.first_kind_name = dr["first_kind_name"].ToString();
            }
            DataTable de = itb.SelectSecondByID(s.second_kind_id.ToString());
            foreach (DataRow dd in de.Rows)
            {
                s.second_kind_name = dd["second_kind_name"].ToString();
            }
            if (itb.TKtAdd(s) > 0)
            {
                return Redirect("Index");
            }
            else
            {
                return Redirect("Index");
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            
            config_file_third_kindModel sm = new config_file_third_kindModel()
            {
                ftk_id = id
            };
            int result = itb.TKDel(sm);
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
            DropList3();
            config_file_third_kindModel sm = new config_file_third_kindModel()
            {
                ftk_id = id
            };
            List<config_file_third_kindModel> list = itb.TelectBy(sm);
            config_file_third_kindModel st = new config_file_third_kindModel()
            {
                ftk_id = list[0].ftk_id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_is_retail = list[0].third_kind_is_retail,
                third_kind_name = list[0].third_kind_name,
                third_kind_sale_id = list[0].third_kind_sale_id
            };
            return View(st);
        }

        //
        // POST: /Studente/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, config_file_third_kindModel s)
        {
            if (itb.TKUpdate(s) > 0)
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