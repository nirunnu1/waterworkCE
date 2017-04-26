using System;
using System.Web.Mvc;
using waterwork.DAL;
using waterwork.Models;
using static waterwork.Models.Createinvoiceperiods;

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
            AssetDbContext Context = new AssetDbContext();
            var data = Context.Water_usage.Find(item.customer_services_id);
            data.invoiceperiods_id = new Guid(Session["invoiceperiods_id"].ToString());
            data.water_Unit = item.water_Unit;
            Context.SaveChanges();
            Session["invoiceperiods_id"] = data.invoiceperiods_id;
            ViewBag.time = Session["invoiceperiods_id"];
            if (DAL.DALWater_usage.GetWater_usage_inid(data.invoiceperiods_id)==0)
            {
                var i = Context.Createinvoiceperiods.Find(data.invoiceperiods_id);
                i.status = Statusinvoiceperiods.ready;
                Context.SaveChanges();
                DALbill_Water.bill_Water_Add(data.invoiceperiods_id);
            }
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
        public ActionResult invoiceperiods()
        {
            var item = DAL.DALCreateinvoiceperiods.Getinvoiceperiods();
            return View(item);
        }
        
    }
}