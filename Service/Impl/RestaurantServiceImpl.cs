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
    public class RestaurantServiceImpl : IRestaurantService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RestaurantServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public DataCollection<RestaurantDto> GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<RestaurantDto>>(
               _context.Restaurants
               .Include(x => x.Category)
               .OrderBy(x => x.RestaurantId)
               .AsQueryable()
               .Paged(page, take)
               );
        }

        public DataCollection<RestaurantDto> GetByCategory(int CategoryId, int page, int take)
        {
            return _mapper.Map<DataCollection<RestaurantDto>>(
               _context.Restaurants
               .Include(x => x.Category)
               .OrderBy(x => x.RestaurantId)
               .AsQueryable().Where(x => x.CategoryId == CategoryId)
               .Paged(page, take)
               );
        }
    }
}
