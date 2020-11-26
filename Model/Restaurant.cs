using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public int RestauranteOwnerId { get; set; }
        public RestaurantOwner RestaurantOwner { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Menu> Menus { get; set; }
    }
}
