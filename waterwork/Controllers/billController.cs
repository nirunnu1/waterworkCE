using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace waterwork.Controllers
{
    public class billController : Controller
    {
        // GET: bill
        public ActionResult bill_index()
        {
            return View();
        }
        public ActionResult bill_dataview()
        {
            Guid id =new Guid( Request.Params["Bid"]);
            AssetDbContext Context = new AssetDbContext();
            var item = Context.bill_Water_usage.Where(x=>x.Water_usage.invoiceperiods_id== id);
            return PartialView(item.ToList());
        }
    }
}