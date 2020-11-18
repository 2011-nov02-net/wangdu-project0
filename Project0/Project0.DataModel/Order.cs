using System;
using System.Collections.Generic;

#nullable disable

namespace Project0.DataModel
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int LocationId { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
