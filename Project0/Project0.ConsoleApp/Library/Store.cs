using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.ConsoleApp.Library
{
    public class Store
    {
        public int StoreId { get; set; }
        public HashSet<Customer> Customers { get; set; } = new HashSet<Customer>();
        public string Customer { get; set; }

        public Store(int storeId, string customer)
        {
            StoreId = storeId;
            Customer = customer;
        }


    }
}