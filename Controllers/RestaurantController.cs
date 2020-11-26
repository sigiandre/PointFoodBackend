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
    [Route("restaurants")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet]
        public ActionResult<DataCollection<RestaurantDto>> GetAll(int page, int take)
        {
            return _restaurantService.GetAll(page, take);
        }

        [HttpGet("categories/{categoryId}")]
        public ActionResult<DataCollection<RestaurantDto>> GetByCategory(int categoryId, int page, int take)
        {
            return _restaurantService.GetByCategory(categoryId, page, take);
        }
    }
}
