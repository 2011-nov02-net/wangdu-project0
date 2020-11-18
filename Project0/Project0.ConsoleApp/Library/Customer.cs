using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.ConsoleApp.Library
{
    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        
        // For Displaying the Order History of a customer


        //CONSTRUCTORS
        public Customer(int customerId, string name)
        {
            Name = name;
            Id = customerId;
            
        }
        public Customer(string name)
        {
            Name = name;
        }
        override public string ToString()
        {
            return $"Name:  {Name}  CustomerId: {Id}";
        }
    }

}
