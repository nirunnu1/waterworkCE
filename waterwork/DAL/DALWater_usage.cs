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
        public static void InsertWater_usage(Water_usage item)
        {
            AssetDbContext Context = new AssetDbContext();
            if (item != null)
            {
                item.Uid = Guid.NewGuid();
                Context.Water_usage.Add(item);
                Context.SaveChanges();
            }
        }
    }
}