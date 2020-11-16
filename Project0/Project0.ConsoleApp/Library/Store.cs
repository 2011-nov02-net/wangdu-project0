using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.ConsoleApp.Library
{
     public class Store
     {
        private static int StoreId = 0;
        public List<Customer> CustomerList { get; set; }
       

        public int Id;
        public Store()
        {
            Id = StoreId;
            CustomerList = new List<Customer>();
            ++StoreId;
        }

 
    }
}
