using System;
using System.Collections;
using System.Linq;
using waterwork.Models;

namespace waterwork.DAL
{
    public class DALCreateinvoiceperiods
    {
        private static AssetDbContext Context = new AssetDbContext();
        public static IEnumerable Getinvoiceperiods()
        {
            return Context.Createinvoiceperiods.ToList();
        }
        public static void Insertinvoiceperiods(Createinvoiceperiods item)
        {
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
            return Context.Createinvoiceperiods.Where(x=>x.status== Createinvoiceperiods.Statusinvoiceperiods.Wait).ToList();
        }
    }
}