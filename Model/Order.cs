using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public List<OrderDetail> Products { get; set; }

        public DateTime RegisteredAt { get; set; }
        public DateTime DeliveredAt { get; set; }
        
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public bool Delivery { get; set; }
        public string Address { get; set; }
        public decimal Total { get; set; }

        public int StateId { get; set; }
        public State State { get; set; }
    }
}
