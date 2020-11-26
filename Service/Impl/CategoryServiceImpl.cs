using AutoMapper;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service.Impl
{
    public class CategoryServiceImpl : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CategoryServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public DataCollection<CategoryDto> GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<CategoryDto>>(
                _context.Categories
                .OrderBy(x => x.CategoryId)
                .AsQueryable()
                .Paged(page, take)
                );
        }
    }
}
