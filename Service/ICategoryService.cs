using PointFood.Commons;
using PointFood.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service
{
    public interface ICategoryService
    {
        DataCollection<CategoryDto> GetAll(int page, int take);
    }
}
