using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Card
    {
        public int CardId { get; set; }
        public string Number { get; set; }
        
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
