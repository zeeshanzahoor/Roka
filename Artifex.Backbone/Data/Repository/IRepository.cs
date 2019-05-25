using ArtifexPay.Backbone.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Data.Repository
{
    public interface IRepository<T> where T : BaseEntity, IEntity
    {
        void Save(T Entity);
        IQueryable<T> All { get; }
        void Delete(T entity);
        void Delete(IList<T> entity);
        void SaveChanges();
        T SelectById(int Id);
    }
}
