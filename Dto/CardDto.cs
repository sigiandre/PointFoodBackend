using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class CardDto
    {
        public int CardId { get; set; }
        public string Number { get; set; }
        public string ClientName { get; set; }
    }

    public class CardCreateDto
    {
        public string Number { get; set; }
        public int ClientId { get; set; }
    }

    public class CardUpdateDto
    {
        public string Number { get; set; }
    }
}
