using System;
using System.Collections;
using System.Linq;
using waterwork.Models;

namespace waterwork.DAL
{
    public class DALWater_usage
    {
        public static IEnumerable GetWater_usage()
        {
            AssetDbContext Context = new AssetDbContext();
            return Context.Water_usage.Where(x => x.customer_services.status == customer_services.Status.ready).ToList();
        }
        public static IEnumerable GetWater_usage_id(Guid id)
        {
            AssetDbContext Context = new AssetDbContext();
            var item = Context.Water_usage.Where(x => x.invoiceperiods_id == id && x.water_Unit == 0).ToList();
            return item.ToList();
        }
        public static int GetWater_usage_inid(Guid id)
        {
            AssetDbContext Context = new AssetDbContext();
            int item = Context.Water_usage.Where(x => x.invoiceperiods_id == id && x.water_Unit == 0).Count();
            return item;
        }

    }
}