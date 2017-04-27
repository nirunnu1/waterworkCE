using System;
using System.Linq;
using waterwork.Models;
namespace waterwork.DAL
{
    public class DALbill_Water
    {
        public static void bill_Water_Add(Guid id)
        {
            AssetDbContext Context = new AssetDbContext();
            var Water_use = Context.Water_usage.Where(x=>x.invoiceperiods_id==id).ToList();
            foreach (var i in Water_use)
            {
                var data = new bill_Water_usage
                {
                    Uid = Guid.NewGuid(),
                    Water_usage_id = i.Uid,
                    water_usagefirst = water_usagefirst(i.customer_services_id),
                    water_usageafter = i.water_Unit,
                    unit = i.water_Unit- water_usagefirst(i.customer_services_id),
                    service_charge = 5,
                    Minimum_rate = Minimum_rate(i.water_Unit - water_usagefirst(i.customer_services_id)),
                    price =( ( i.water_Unit- water_usagefirst(i.customer_services_id)) * 7)+5+ Minimum_rate(i.water_Unit - water_usagefirst(i.customer_services_id)),
                    status = bill_Water_usage.Statusbill.Wait
                };
                Context.bill_Water_usage.Add(data);
                Context.SaveChanges();
            }
        }
        public static int water_usagefirst(Guid id )
        {
            int unit;
            AssetDbContext Context = new AssetDbContext();
            bill_Water_usage [] item = Context.bill_Water_usage.Where(x=>x.Water_usage.customer_services_id==id).OrderBy(x=>x.water_usagefirst).ToArray();
            if (item.Count()==0)
            {
                customer_services [] i = Context.customer_services.Where(x => x.Uid == id).ToArray();
                return i[0].meter_First_unit.Value ;
            }
            else {
                return item[item.Count()-1].water_usageafter;
            }
            
        }
        public static int Minimum_rate(int item)
        {
            if ((item*7)>=23)
            {
                return 0;
            }
            else
            {
               return 23- (item * 7) ;
            }
        }
    }
}