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
                Context.Createinvoiceperiods.Add(item);
                Context.SaveChanges();
            }
        }
    }
}