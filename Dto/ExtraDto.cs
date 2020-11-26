using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class ExtraOrderDto
    {
        public int ExtraId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class ExtraMenuDto
    {
        public int ExtraId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
