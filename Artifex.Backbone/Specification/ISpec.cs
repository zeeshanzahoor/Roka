using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Specification
{
    public interface ISpec<T>
    {
        IQueryable<T> ApplySpec(IQueryable<T> o);
    }
}
