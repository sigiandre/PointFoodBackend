using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class ProductExtra
    {
        public int ProductExtraId { get; set; }

        public int MenuProductId { get; set; }
        public MenuProduct MenuProduct { get; set; }

        public int ExtraId { get; set; }
        public Extra Extra { get; set; }
    }
}
