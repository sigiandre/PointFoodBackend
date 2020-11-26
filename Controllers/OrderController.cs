using Microsoft.AspNetCore.Mvc;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public ActionResult Create(OrderCreateDto order)
        {
            var result = _orderService.Create(order);

            return CreatedAtAction("GetById", new { orderId = result.OrderId }, result);
        }

        [HttpGet("{orderId}")]
        public ActionResult<OrderDto> GetById(int orderId)
        {
            return _orderService.GetById(orderId);
        }

        [HttpGet("restaurants/{restaurantId}")]
        public ActionResult<DataCollection<OrderDto>> GetByRestaurant(int restaurantId, int page, int take)
        {
            return _orderService.GetByRestaurant(restaurantId, page, take);
        }

        [HttpGet("restaurants/{restaurantId}/states/{stateId}")]
        public ActionResult<DataCollection<OrderDto>> GetByStateAndRestaurant(int restaurantId, int stateId, int page, int take)
        {
            return _orderService.GetByStateAndRestaurant(restaurantId, stateId, page, take);
        }

        [HttpPut("{orderId}")]
        public ActionResult UpdateState(int orderId, OrderUpdateDto model)
        {
            _orderService.UpdateState(orderId, model);
            return Ok();
        }
    }
}
