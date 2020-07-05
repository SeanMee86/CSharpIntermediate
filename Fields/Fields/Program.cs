using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            Console.WriteLine(customer.Orders.Count);
            Console.WriteLine(customer.Id);
            customer.Name = "Sean";
            Console.WriteLine(customer.Name);

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
