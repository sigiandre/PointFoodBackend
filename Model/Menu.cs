using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public List<MenuProduct> Products { get; set; }
    }
}
