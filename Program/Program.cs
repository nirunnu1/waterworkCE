using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new waterwork.AssetDbContext();
            Console.WriteLine("Name >>  ");
            var customers = Context.customer_services.ToList();
            foreach (var i  in customers)
            {
               
            }

        }
    }
}
