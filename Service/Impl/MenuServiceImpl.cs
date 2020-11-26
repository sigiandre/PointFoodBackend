using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service.Impl
{
    public class MenuServiceImpl : IMenuService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MenuServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public DataCollection<MenuDto> GetByRestaurant(int restaurantId, int page, int take)
        {
            return _mapper.Map<DataCollection<MenuDto>>(
                _context.Menus.OrderBy(x => x.MenuId)
                .Include(x => x.Products)
                    .ThenInclude(x => x.Extras)
                        .ThenInclude(x => x.Extra)
                .Include(x => x.Products)
                    .ThenInclude(x => x.Product)
                .AsQueryable().Where(x => x.RestaurantId == restaurantId)
                .Paged(page, take)
                );
        }
    }
}
