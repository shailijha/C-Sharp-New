using System.Collections.Generic;

namespace Practice
{
    public class Customer
    {
        public int id;
        public string name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id): this()
        {
            this.id = id;
        }

        public Customer(int id, string name): this(id)
        {
            this.name = name;
        }
    }
}
