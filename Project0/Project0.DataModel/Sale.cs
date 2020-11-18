using System;
using System.Collections.Generic;

#nullable disable

namespace Project0.DataModel
{
    public partial class Sale
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
