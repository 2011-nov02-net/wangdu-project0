using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.ConsoleApp.Library
{
    class Order
    {

        private Location _storeid;
        private Customer _customerid;
        public DateTime OrderTime { get; private set; }
        public List<Product> ProductList { get; set; }
        public Location StoreID { get => _storeid; set => _storeid = value; }
        public Customer CustomerId { get => _customerid; set => _customerid = value; }


        public Order(Location sID, Customer cID)
        {

            StoreID = sID;
            this.CustomerId = cID;
            ProductList = new List<Product>();
            OrderTime = DateTime.Now;

        }


    }
}
