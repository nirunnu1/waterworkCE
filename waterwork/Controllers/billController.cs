using System;
using System.Linq;
using System.Web.Mvc;
using static waterwork.DAL.GridViewExportDemoHelper;
using waterwork.DAL;

namespace waterwork.Controllers
{
    public class billController : Controller
    {
        // GET: bill
        private AssetDbContext Context = new AssetDbContext();
        public ActionResult bill_index()
        {
            return View();
        }
        public ActionResult bill_dataview()
        {
            Guid id =new Guid( Request.Params["Bid"]);
            var item = Context.bill_Water_usage.Where(x=>x.Water_usage.invoiceperiods_id== id);
            return PartialView(item.ToList());
        }
        public ActionResult bill_report()
        {
            return View(Context.customer_services.ToList());
        }
            public ActionResult bill_report_view()
        {
            Guid id = new Guid(Request.Params["Bid"]);
            var item = Context.bill_Water_usage.Where(x => x.Water_usage.invoiceperiods_id == id);
            return PartialView(item.ToList());
        }
        public ActionResult bill_report_dataview(Guid  id)
        {
            var item = Context.bill_Water_usage.Where(x => x.Water_usage.customer_services_id == id);
            ViewBag.id = id;
            return View(item.ToList());
        }


        public ActionResult ExportTo(string id)
        {

            GridViewExportFormat format = GetExportFormat();
            if (GridViewExportDemoHelper.ExportFormatsInfo.ContainsKey(format))
                return GridViewExportDemoHelper.ExportFormatsInfo[format](GridViewExportDemoHelper.ExportGridViewSettings, Context.bill_Water_usage.Where(x => x.Water_usage.customer_services_id.ToString() == id).ToList());
            return RedirectToAction("bill_report_dataview");
        }
        protected GridViewExportFormat GetExportFormat()
        {
            var result = GridViewExportFormat.None;
            Enum.TryParse(Request.Params["ExportFormat"], out result);
            return result;
        }

    }
}