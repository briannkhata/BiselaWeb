﻿using BiselaWeb.Data;
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
            using (db = new BEntities())
            {
                ViewBag.paytypes = db.PaymentTypes.ToList();
                ViewBag.users = db.Users.Where(x=>x.Deleted == 0).ToList();
                ViewBag.saletypes = db.Sales.GroupBy(x=>x.SaleType).ToList();
            }
            return View();
        }

        public ActionResult Receivings()
        {
            return View();
        }

        public ActionResult FilterSales()
        {
            DateTime FromDate = DateTime.Parse(Request.Form["FromDate"]);
            DateTime ToDate = DateTime.Parse(Request.Form["ToDate"]);
            var SaleType = Request.Form["SaleType"];
            var PaymentTypeId = Request.Form["PaymentTypeId"];
            var UserId = Request.Form["UserId"];

            ViewBag.Title = "Sales For | " + FromDate.ToString("dd/M/yyyy") + " To " + ToDate.ToString("dd/M/yyyy");
            using (db = new BEntities())
            {
                ViewBag.sales = db.vwSalesReports.Where(x => x.DateSold >= FromDate && x.DateSold <= ToDate).ToList();
            }
            return View();
        }

        public ActionResult FilterReceivings()
        {
            DateTime FromDate = DateTime.Parse(Request.Form["FromDate"]);
            DateTime ToDate = DateTime.Parse(Request.Form["ToDate"]);
            ViewBag.Title = "Receivings For | " + FromDate.ToString("dd/M/yyyy") + " To " + ToDate.ToString("dd/M/yyyy");
            using (db = new BEntities())
            {
                ViewBag.receivings = db.vwReceivingReports.Where(x => x.ReceivingDate >= FromDate && x.ReceivingDate <= ToDate).ToList();
            }
            return View();
        }

        public ActionResult FilterVat()
        {
            DateTime FromDate = DateTime.Parse(Request.Form["FromDate"]);
            DateTime ToDate = DateTime.Parse(Request.Form["ToDate"]);
           

            ViewBag.Title = "VAT For | " + FromDate.ToString("dd/M/yyyy") + " To " + ToDate.ToString("dd/M/yyyy");
            using (db = new BEntities())
            {
                ViewBag.vats = db.vwSalesReports.Where(x => x.DateSold >= FromDate && x.DateSold <= ToDate).ToList();
            }
            return View();
        }
    }
}