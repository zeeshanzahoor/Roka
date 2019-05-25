using ArtifexPay.Backbone.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Services.Internals
{
    internal class BaseService 
    {
        public PagedResult<T> ApplyPagination<T>(IQueryable<T> c, PaginationArgs args)
        {
            PagedResult<T> result = new PagedResult<T>()
            {
                Total = c.Count(),
                Data = c.Skip(args.CurrentPage * args.PageSize).Take(args.PageSize).ToList(),
            };
            return result;
        }
    }
}
