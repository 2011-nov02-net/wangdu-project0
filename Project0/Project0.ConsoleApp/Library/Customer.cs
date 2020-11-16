using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.ConsoleApp.Library
{
    public class Customer
    {
        public string Name { get; set; }
        private static int IdSeed = 0;
        public int CustomerId;
        //CONSTRUCTORS
        public Customer(string name)
        {
            CustomerId = IdSeed;
            Name = name;
            ++IdSeed;
        }
        override public string ToString()
        {
            return "Name: " + Name + " CustomerId: " + CustomerId;
        }
    }
}
