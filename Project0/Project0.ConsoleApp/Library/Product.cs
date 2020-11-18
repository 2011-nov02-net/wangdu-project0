using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.ConsoleApp.Library
{
    public class Product
    {
        private int _id;
        private decimal _price;


        // Product ID
        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("ID must be positive");
                }
                else
                {
                    _id = value;
                }
            }
        }

        // Product Price
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be positive");
                }
                else
                {
                    _price = value;
                }
            }
        }

        // Constructor
        public Product(int id, decimal price)
        {
            this.Id = id;
            this.Price = price;
        }
    }
}

