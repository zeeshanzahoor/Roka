using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Specification
{
    public abstract class BaseSpec<T> : ISpec<T>
    {
        public abstract IQueryable<T> ApplySpec(IQueryable<T> c);
    }
}
