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
                    water_usagefirst = 0,
                    water_usageafter = i.water_Unit,
                    unit = 0 - i.water_Unit,
                    service_charge = 15,
                    Minimum_rate = 35,
                    price = (0 - i.water_Unit) * 5,
                    status = bill_Water_usage.Statusbill.Wait
                };
                Context.bill_Water_usage.Add(data);
                Context.SaveChanges();
            }
        }
    }
}