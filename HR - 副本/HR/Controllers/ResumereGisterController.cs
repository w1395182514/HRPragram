using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
using IHRBLL;
using Model;
using System.Data;
using Newtonsoft.Json;

namespace HR.Controllers
{
    public class ResumereGisterController : Controller
    {
        IEngageResumeBLL irb = IOCcotainer.CreateERBLL();
        // GET: resumeregister
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DropList1()
        {
            DataTable dt = irb.SelectType();
            return Content(JsonConvert.SerializeObject(dt));
        }

        public ActionResult DropList2()
        {
            string id =Request["id"];
            DataTable dt = irb.SelectType2(int.Parse(id));
            return Content(JsonConvert.SerializeObject(dt));
        }

        public ActionResult Insert()
        {
            return View();
        }
    }
}