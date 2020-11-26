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
    [Route("menus")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet("restaurants/{restaurantId}")]
        public ActionResult<DataCollection<MenuDto>> GetByRestaurant(int restaurantId, int page, int take)
        {
            return _menuService.GetByRestaurant(restaurantId, page, take);
        }
    }
}
