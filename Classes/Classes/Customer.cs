using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        //Below code is unnecessary, better to:
        //customer.Id = someId
        //customer.Name = someName

        //public Customer(int id)
        //    : this()
        //{
        //    this.Id = id;
        //}

        //public Customer(int id, string name)
        //    : this(id)
        //{
        //    this.Name = name;
        //}
    }
}
