using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Model;
using PointFood.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service.Impl
{
    public class OrderServiceImpl : IOrderService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public OrderServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public OrderDto Create(OrderCreateDto model)
        {
            var entry = _mapper.Map<Order>(model);
            entry.RegisteredAt = DateTime.Now;
            CalculateSubTotalDishExtra(entry.Products);
            CalculateSubtotalOrderDetail(entry.Products);
            entry.Total = entry.Products.Sum(x => x.SubTotal);
            entry.StateId = 1;

            _context.Add(entry);
            _context.SaveChanges();

            return _mapper.Map<OrderDto>(GetById(entry.OrderId));
        }

        public OrderDto GetById(int id)
        {
            return _mapper.Map<OrderDto>(
                _context.Orders
                .Include(x => x.Client)
                .Include(x => x.Restaurant)
                    .ThenInclude(x => x.Category)
                .Include(x => x.Products)
                    .ThenInclude(x => x.Extras)
                        .ThenInclude(x => x.Extra)
                .Include(x => x.Products)
                    .ThenInclude(x => x.Product)
                .Include(x => x.State)
                .Single(x => x.OrderId == id));
        }

        public void CalculateSubTotalDishExtra(IEnumerable<OrderDetail> products)
        {
            foreach(var product in products)
            {
                foreach(var extra in product.Extras)
                {
                    extra.SubTotal = _context.Extras.Single(x => x.ExtraId == extra.ExtraId).Price * extra.Quantity;
                }
            }
        }

        public void CalculateSubtotalOrderDetail(IEnumerable<OrderDetail> products)
        {
            foreach(var product in products)
            {
                product.SubTotal = product.Extras.Sum(x => x.SubTotal) + _context.Products.Single(x => x.ProductId == product.ProductId).Price;        
            }
        }

        public DataCollection<OrderDto> GetByRestaurant(int RestaurantId, int page, int take)
        {
            return _mapper.Map<DataCollection<OrderDto>>(
                _context.Orders.OrderBy(x => x.OrderId)
                .Include(x => x.Client)
                .Include(x => x.Restaurant)
                    .ThenInclude(x => x.Category)
                .Include(x => x.Products)
                    .ThenInclude(x => x.Extras)
                        .ThenInclude(x => x.Extra)
                .Include(x => x.Products)
                    .ThenInclude(x => x.Product)
                .Include(x => x.State)
                .AsQueryable().Where(x => x.RestaurantId == RestaurantId)
                .Paged(page, take)
                );
        }


        public void UpdateState(int id, OrderUpdateDto model)
        {
            var entry = _context.Orders.Single(x => x.OrderId == id);
            entry.StateId = model.StateId;

            _context.SaveChanges();
        }

        public DataCollection<OrderDto> GetByStateAndRestaurant(int RestaurantId, int StateId, int page, int take)
        {
            return _mapper.Map<DataCollection<OrderDto>>(
                _context.Orders.OrderBy(x => x.OrderId)
                .Include(x => x.Client)
                .Include(x => x.Restaurant)
                    .ThenInclude(x => x.Category)
                .Include(x => x.Products)
                    .ThenInclude(x => x.Extras)
                        .ThenInclude(x => x.Extra)
                .Include(x => x.Products)
                    .ThenInclude(x => x.Product)
                .Include(x => x.State)
                .AsQueryable().Where(x => x.RestaurantId == RestaurantId && x.StateId == StateId)
                .Paged(page, take)
                );
        }

    }
}
