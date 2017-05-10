using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using waterwork.DAL;
using waterwork.Models;
using static waterwork.Models.Createinvoiceperiods;

namespace waterwork.Controllers
{
    public class Water_usageController : Controller
    {
        private static AssetDbContext Context = new AssetDbContext();
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
            if (radioButtonList ==1) { return RedirectToAction("ExportToExcel",new {item=item }); }
            Session["invoiceperiods_id"] = item;
            return RedirectToAction("Water_usageAdd");
        }
        public ActionResult ExportToExcel(Guid item)
        {
            GridView gv = new GridView();
            gv.DataSource = Context.Water_usage.Where(x => x.invoiceperiods_id == item).Select(
               x => new {
                   meter_id = x.customer_services.meter_id,
                   firstname = x.customer_services.customer.firstname,
                   lastname = x.customer_services.customer.lastname,
                   Unit = x.water_Unit
               }).ToList();
            gv.DataBind();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=Excel.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            gv.RenderControl(htw);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
            return RedirectToAction("Index", "Water_usage");
        }

        public ActionResult Water_usageAdd(string item)
        {
            ViewBag.time = Session["invoiceperiods_id"];

           return View(DAL.DALWater_usage.GetWater_usage());
        }
        [HttpPost]
        public ActionResult Water_usageAdd(Water_usage item)
        {
            var data = Context.Water_usage.Find(item.customer_services_id);
            int water_usagefirst;
            bill_Water_usage[] bill = Context.bill_Water_usage.Where(x => x.Water_usage.customer_services_id == data.customer_services_id).OrderByDescending(x => x.Water_usage.Createinvoiceperiods.date).ToArray();
            Water_usage[] cus = Context.Water_usage.Where(x => x.Uid == item.customer_services_id).ToArray();
            if (bill.Count() == 0) { water_usagefirst = cus[0].customer_services.meter_First_unit.Value; }
            else { water_usagefirst = bill[0].water_usageafter; }
            Session["invoiceperiods_id"] = data.invoiceperiods_id;
            ViewBag.time = Session["invoiceperiods_id"];
            if (item.water_Unit > water_usagefirst)
            {

                data.invoiceperiods_id = new Guid(Session["invoiceperiods_id"].ToString());
                data.water_Unit = item.water_Unit;
                Context.SaveChanges();
                if (DAL.DALWater_usage.GetWater_usage_inid(data.invoiceperiods_id) == 0)
                {
                    var i = Context.Createinvoiceperiods.Find(data.invoiceperiods_id);
                    i.status = Statusinvoiceperiods.ready;
                    Context.SaveChanges();
                    DALbill_Water.bill_Water_Add(data.invoiceperiods_id);
                }
                return View(DAL.DALWater_usage.GetWater_usage());
            }
            ViewBag.error = "หน่วยที่ใช้ไม่ถูกต้อง หน่วยเดือนก่อนหน้า : " + water_usagefirst;
            
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
            return PartialView(item);
        }
        
    }
}