using Roka.Backbone.Audit;
using Roka.Backbone.Audit.Types;
using Roka.Backbone.Data.Entity;
using Roka.Backbone.Data.Repository;
using System.Diagnostics;
using System.Linq;

namespace Roka.Core.Data.Internals
{
    [DebuggerStepThrough]
    internal class NHibernateRepository<T> : IRepository<T> where T : BaseEntity, IEntity
    {
        public IQueryable<T> All => throw new System.NotImplementedException();

        public void Save(T Entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
