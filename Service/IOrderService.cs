using PointFood.Commons;
using PointFood.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service
{
    public interface IOrderService
    {
        DataCollection<OrderDto> GetByStateAndRestaurant(int RestaurantId, int StateId, int page, int take);
        DataCollection<OrderDto> GetByRestaurant(int RestaurantId, int page, int take);
        OrderDto Create(OrderCreateDto model);
        OrderDto GetById(int id);
        void UpdateState(int id, OrderUpdateDto model);
    }
}
