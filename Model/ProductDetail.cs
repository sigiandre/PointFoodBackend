using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }

        public int OrderDetailId { get; set; }
        public OrderDetail OrderDetail { get; set; }

        public int ExtraId { get; set; }
        public Extra Extra { get; set; }

        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
    }
}
