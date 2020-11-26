using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime SignedUpAt { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Card> Cards { get; set; }
    }
}
