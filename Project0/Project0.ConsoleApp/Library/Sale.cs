using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.ConsoleApp.Library
{
    public class Sale
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Sale(int id, int orderId, int productId, int price, int quantity)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            Price = price;
            Quantity = quantity;
        }

        public Sale()
        {
        }

        override public string ToString()
        {
            return $"OrderId: {OrderId} ProductId: {ProductId} Price: {Price} Quantity: {Quantity}";
        }
    }
}

