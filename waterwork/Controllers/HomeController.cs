using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waterwork.Models;

namespace waterwork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // DXCOMMENT: Pass a data model for GridView
            
            return View();
        }
        public ActionResult GridViewPartialView() 
        {
            return PartialView("GridViewPartialView");
        }
        public ActionResult SearchUserProfile()
        {
            return View(customers.GetSearchUserProfile());
        }
        public ActionResult GridViewSearchUserProfilePartialView()
        {
            return PartialView("GridViewSearchUserProfilePartialView", customers.GetSearchUserProfile());
        }
        public ActionResult AddUserProfile()
        {
            return View();
        }
        public ActionResult AddUserProfilePartialView()
        {
            return PartialView("AddUserProfilePartialView");
        }
        [HttpPost]
        public ActionResult AddUserProfilePartialView(customers item)
        {
            customers.Insertcustomers(item);
            return RedirectToAction("AddServicesProfile", new { id=item.Uid });
        }
        public ActionResult AddServicesProfile(string id, customer_services item)
        {

            item.Uid = Guid.NewGuid();
            item.customer_id =new Guid(id);
            return View(item);
        }

        [HttpPost]
        public ActionResult AddServicesProfile(customer_services item)
        {
            item.customer_id = new Guid(Url.RequestContext.RouteData.Values["id"].ToString());
            customer_services.Insertcustomer_services(item);
            Session["Uid"] = item.Uid;
            return RedirectToAction("ReportView");
        }
        public ActionResult AddServicesquantity( )
        {
            AssetDbContext Context = new AssetDbContext();
            string id = Url.RequestContext.RouteData.Values["id"].ToString();
            customer_services[] cus = Context.customer_services.Where(x=>x.customer_id.ToString() == id).ToArray();

            return PartialView("AddServicesquantity",cus.ToList());
        }
        public ActionResult Information()
        {
            AssetDbContext Context = new AssetDbContext();
            var cus = customer_services.Getcustomer_services();

            return View( cus);
        }


        public ActionResult ReportView()
        {
            return View();
        }

        public ActionResult DocumentViewerPartial()
        {
            AssetDbContext Context = new AssetDbContext();
            string id = Session["Uid"].ToString();
            var pro = Context.customer_services.Where(x=>x.Uid.ToString() == id).ToList();
            return PartialView("DocumentViewerPartial",pro);
        }
        public ActionResult ExportDocumentViewer()
        {
            AssetDbContext Context = new AssetDbContext();
            string id = Session["Uid"].ToString();
            var pro = Context.customer_services.Where(x => x.Uid.ToString() == id).ToList();
            XtraReport1 report = new XtraReport1();
            report.DataSource = pro;
            return ReportViewerExtension.ExportTo(report);
        }



    }
}

public enum HeaderViewRenderMode { Full, Title }