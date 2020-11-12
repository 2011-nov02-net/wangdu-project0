using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Order
    {
        //Order id
        private static int OrderID = 0;
        //has a store location
        public Store Location { get; set; }
        // has a customer
        public Customer ID { get; set; }
        // has an order time
        public DateTime Time { get; set; }
        // contain mutiple kinds of product in the same order
        public List<Product> kinds;
        //reject orders with unreasonably high product quantities

        //constructor

        public Order(Store location, Customer id, DateTime time, List<Product> k)
        {
            this.Location = location;
            this.ID = id;
            this.Time = time;
            this.kinds = k;
            ++OrderID;
        }

    }
}
