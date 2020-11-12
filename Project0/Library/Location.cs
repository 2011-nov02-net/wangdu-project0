using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Location
    {
        public string StoreName { get; private set; }
        //Constructor
        public Location(string storename)
        {
            this.StoreName = storename;
        }

        public List<Product> Inventory { get; private set; } = new List<Product>();
    }
}
