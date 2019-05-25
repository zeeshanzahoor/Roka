using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Pagination
{
    public class PagedResult<T>
    {
        public int Total { get; set; }
        public IList<T> Data { get; set; }
    }
}
