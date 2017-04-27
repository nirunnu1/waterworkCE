using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using waterwork.Models;

namespace waterwork.DAL
{
    public class DALCreateinvoiceperiods
    {
        public static IEnumerable Getinvoiceperiods()
        {
            AssetDbContext Context = new AssetDbContext();
            return Context.Createinvoiceperiods.ToList();
        }
        public static void Insertinvoiceperiods(Createinvoiceperiods item)
        {
            AssetDbContext Context = new AssetDbContext();
            if (item != null)
            {
                item.Uid = Guid.NewGuid();
                item.num = Context.customer_services.Where(x => x.status == customer_services.Status.ready).Count();
                item.status = Createinvoiceperiods.Statusinvoiceperiods.Wait;
                Context.Createinvoiceperiods.Add(item);
                Context.SaveChanges();

                foreach (var i in Context.customer_services.Where(x => x.status == customer_services.Status.ready))
                {
                    AssetDbContext add = new AssetDbContext();
                    var data = new waterwork.Models.Water_usage()
                    {
                        Uid = Guid.NewGuid(),
                        invoiceperiods_id = item.Uid,
                        customer_services_id=i.Uid,
                        water_Unit=0
                    };
                    add.Water_usage.Add(data);
                    add.SaveChanges();
                };
            }
            
        }
        public static IEnumerable GetinvoiceperiodsWait()
        {
            AssetDbContext Context = new AssetDbContext();
            return Context.Createinvoiceperiods.Where(x=>x.status== Createinvoiceperiods.Statusinvoiceperiods.Wait).ToList();
        }
    }
}