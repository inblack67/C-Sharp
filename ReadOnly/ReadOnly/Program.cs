using System;
using System.Collections.Generic;
namespace ReadOnly
{
    class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1, "Scooby");

            customer.orders.Add(new Order());
            customer.orders.Add(new Order());
            customer.orders.Add(new Order());
            customer.orders.Add(new Order());
            customer.orders.Add(new Order());

            Console.WriteLine("No. of Order class objects in Customer.orders -> " + customer.orders.Count);

            //customer.promote();
            //Console.WriteLine("No. of Order class objects in Customer.orders -> " + customer.orders.Count);
            // data lost saved by read only thang

        }
    }

    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public readonly List<Order> orders = new List<Order>();

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.name = name;
        }

        public void promote()
        {
            //orders = new List<Order>(); //can't be re-init thanks to read only
        }
    }

    public class Order
    {

    }
}
