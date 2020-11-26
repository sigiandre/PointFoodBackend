using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Commons
{
    public static class Paging
    {
        public static DataCollection<T> Paged<T>(
               this IQueryable<T> query,
               int page,
               int take
           ) where T : class
        {
            var result = new DataCollection<T>();

            result.Total = query.Count();
            result.Page = page;

            if (result.Total > 0)
            {
                result.Pages = Convert.ToInt32(
                    Math.Ceiling(
                        Convert.ToDecimal(result.Total) / take
                    )
                );

                result.Items = query.Skip((page - 1) * take)
                                            .Take(take)
                                            .ToList();
            }

            return result;
        }
    }
}
