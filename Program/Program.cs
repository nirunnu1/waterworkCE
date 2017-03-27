using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using waterwork.Models;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new waterwork.AssetDbContext();
            Console.WriteLine("Name >>  ");
            var customers = Context.customer_services.Where(x=>x.customer_id.ToString() == "89f19211-2b93-4967-98a1-1fe9e69e2053");
            foreach (var i  in customers)
            {
                Context.customer_services.Remove(i);
                Context.SaveChanges();
            }

        }
    }
}
