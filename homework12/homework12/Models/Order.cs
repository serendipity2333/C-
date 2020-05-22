using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework12.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int TotalPrice { get; set; }

    }
}
