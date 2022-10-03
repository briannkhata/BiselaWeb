using BiselaWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiselaWeb.Controllers
{
    public class ReportController : Controller
    {
        BEntities db;
        // GET: Report
        public ActionResult Vat()
        {
            return View();
        }

        public ActionResult Stock()
        {
            using (db = new BEntities())
            {
                ViewBag.stock = db.vwStockReports.ToList();
            }
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

        public ActionResult FilterSales()
        {
           var FromDate = Request.Form["FromDate"];
           var ToDate = Request.Form["ToDate"];
            using (db = new BEntities())
            {
                ViewBag.sales = db.vwSalesReports.Where(x => x.DateSold >= FromDate && x.DateSold <= ToDate).ToList();
            }
            return View();
        }
    }
}