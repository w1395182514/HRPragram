using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IOC;
using IHRBLL;
using System.Data;

namespace HR.Controllers
{
    public class LoginController : Controller
    {
        ILoginBLL igb = IOCcotainer.CreateStudentBLL();
        // GET: Login
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginModel m)
        {
            DataTable dt = igb.Login(m);
            string name;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    name = item["u_true_name"].ToString();
                }
                return RedirectToAction("../Client/Index");
            }
            else
            {
                return View();
            }
            
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
