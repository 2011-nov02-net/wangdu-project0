using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Customer
    {
        private static int id = 1;
        // Properties
        
        public int ID { get; }
        public string firstname { get; private set; }
         
        public string lastname { get; private set; }
        
        public Customer(string firstNames, string lastNames)
        {
            this.ID = id;
            this.firstname = firstNames;
            this.lastname = lastNames;
            ++id;
        }
    }
}
