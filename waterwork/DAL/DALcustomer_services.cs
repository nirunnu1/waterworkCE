using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using waterwork.Models;

namespace waterwork.DAL
{
    public class DALcustomer_services
    {

        public static IEnumerable Getcustomer_services_Wait()
        {
            AssetDbContext Context = new AssetDbContext();
            return Context.customer_services.Where(x => x.status == customer_services.Status.Wait).ToList();
        }
    }
}