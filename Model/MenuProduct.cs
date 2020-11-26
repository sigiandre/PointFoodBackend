using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class MenuProduct
    {
        public int MenuProductId { get; set; }

        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public List<ProductExtra> Extras { get; set; }
    }
}
