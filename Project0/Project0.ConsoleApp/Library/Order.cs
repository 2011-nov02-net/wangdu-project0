using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.ConsoleApp.Library
{
    class Order
    {


        public DateTime OrderTime { get; private set; }
        public List<Product> ProductList { get; set; }
        public List<Product> Price;
        public Location StoreID { get; set; }
        public Customer CustomerId { get; set; }


        public Order(Location sID, Customer cID)
        {

            StoreID = sID;
            this.CustomerId = cID;
            ProductList = new List<Product>();
            OrderTime = DateTime.Now;

        }


    }
}
