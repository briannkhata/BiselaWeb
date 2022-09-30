using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiselaWeb.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Vat()
        {
            return View();
        }

        public ActionResult Stock()
        {
            return View();
        }

        public ActionResult Sales()
        {
            return View();
        }

        public ActionResult Receivings()
        {
            return View();
        }
    }
}