using PointFood.Commons;
using PointFood.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service
{
    public interface IMenuService
    {
        DataCollection<MenuDto> GetByRestaurant(int restaurantId, int page, int take);
    }
}
