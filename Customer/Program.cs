using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {

            //Customer customer = new Customer();
            //customer.Id = 11;
            //customer.Name = "koffi";
            var customer = new Customer();
            //customer.Id = 12;
            /*customer.Name = "koko"*/;
            Console.WriteLine("Mon identifiant est {0} et mon nom est {1}", customer.Id = 12, customer.Name = "koko");

            var order = new Order();
            customer.Orders.Add(order);

            //Console.WriteLine(customer.);
            Console.ReadKey();
        }
    }
}
