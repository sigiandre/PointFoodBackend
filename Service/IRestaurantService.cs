using PointFood.Commons;
using PointFood.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service
{
    public interface IRestaurantService
    {
        DataCollection<RestaurantDto> GetAll(int page, int take);
        DataCollection<RestaurantDto> GetByCategory(int CategoryId, int page, int take);
    }
}
