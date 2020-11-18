using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.ConsoleApp.Library
{
    public class Location
    {
        private string _storeId;
        private int _productId;
        private int _quantity;

        public int ProductID
        {
            get
            {
                return _productId;
            }
            private set
            {
                _productId = value;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            private set
            {
                _quantity = Quantity;
            }
        }
        public Location(int pID)
        {
            ProductID = pID;
            Quantity = 0;
        }
    }
}
