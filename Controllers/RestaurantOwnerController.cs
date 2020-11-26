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
    [Route("restaurantowners")]
    public class RestaurantOwnerController : ControllerBase
    {
        private readonly IRestaurantOwnerService _restaurantOwnerService;

        public RestaurantOwnerController(IRestaurantOwnerService restaurantOwnerService)
        {
            _restaurantOwnerService = restaurantOwnerService;
        }

        [HttpGet("login")]
        public ActionResult<RestaurantOwnerDto> GetByUsernameAndPassword(RestaurantOwnerLoginDto model)
        {
            return _restaurantOwnerService.GetByUsernameAndPassword(model);
        }
    }
}
