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
    public class RestaurantOwnerServiceImpl : IRestaurantOwnerService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RestaurantOwnerServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public RestaurantOwnerDto GetByUsernameAndPassword(RestaurantOwnerLoginDto model)
        {
            return _mapper.Map<RestaurantOwnerDto>(
                _context.RestaurantOwners
                .Include(x => x.Restaurant)
                    .ThenInclude(x => x.Category)
                .Single(x => (x.Username == model.Username) && (x.Password == model.Password))
                );
        }
    }
}
