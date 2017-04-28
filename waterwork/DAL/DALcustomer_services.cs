using System.Collections;
using System.Linq;
using waterwork.Models;

namespace waterwork.DAL
{
    public class DALcustomer_services
    {
        private static AssetDbContext Context = new AssetDbContext();
        public static IEnumerable Getcustomer_services_Wait()
        {
            return Context.customer_services.Where(x => x.status == customer_services.Status.Wait).ToList();
        }
        public static IEnumerable Getcustomer_services_ready()
        {
            return Context.customer_services.Where(x => x.status == customer_services.Status.ready).ToList();
        }
    }
}