using System;
using System.Web.Mvc;
using waterwork.Models;

namespace waterwork.Controllers
{
    public class Water_usageController : Controller
    {
        // GET: Water_usage
        public ActionResult Createinvoiceperiods()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Createinvoiceperiods(Createinvoiceperiods item)
        {
            DAL.DALCreateinvoiceperiods.Insertinvoiceperiods(item);
            return View();
        }
        public ActionResult Water_usage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Water_usage(Guid item,int radioButtonList)
        {
            if (radioButtonList ==1) { return RedirectToAction("Export_XLSX"); }
            Session["invoiceperiods_id"] = item;
            return RedirectToAction("Water_usageAdd");
        }
        public ActionResult Water_usageAdd(string item)
        {
            ViewBag.time = Session["invoiceperiods_id"];

           return View(DAL.DALWater_usage.GetWater_usage());
        }
        [HttpPost]
        public ActionResult Water_usageAdd(Water_usage item)
        {
            item.invoiceperiods_id = new Guid(Session["invoiceperiods_id"].ToString());
            DAL.DALWater_usage.InsertWater_usage(item);
            return View(DAL.DALWater_usage.GetWater_usage());
        }
        public ActionResult Export_XLSX()
        {
            var model = DAL.DALWater_usage.GetWater_usage();
            return View(model);
        }
        public ActionResult ExportWithFormatConditionsPartial()
        {
            var model = DAL.DALWater_usage.GetWater_usage();
            return PartialView("ExportWithFormatConditionsPartial", model);
        }
    }
}