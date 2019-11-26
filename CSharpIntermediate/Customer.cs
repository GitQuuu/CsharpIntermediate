using System.CodeDom;
using System.Collections.Generic;
using System.Security.Principal;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
            : this()
        {
            Id = id;
            
        }

        public Customer(int id, string name)
            :this(id)
        {
            Id = id;
            Name = name;
            
        }

        
     
    }
}