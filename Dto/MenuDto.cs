using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class MenuDto
    {
        public string Name { get; set; }
        public List<MenuProductDto> Products { get; set; }
    }

    public class MenuProductDto
    {
        public ProductMenuDto Product { get; set; }

        public List<ProductExtraDto> Extras { get; set; }
    }

    public class ProductExtraDto
    {
        public ExtraMenuDto Extra { get; set; }
    }
}
