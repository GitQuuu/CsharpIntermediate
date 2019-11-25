using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Qu";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            Console.ReadLine();
        }


    }
}

