using Microsoft.EntityFrameworkCore;
using ArtifexPay.Backbone.Data.Entity;
using ArtifexPay.Backbone.Data.Repository;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ArtifexPay.Backbone.Security;

namespace ArtifexPay.Core.Data.Internals
{
    internal class EFCoreRepository<T> : IRepository<T> where T : BaseEntity, IEntity
    {
        private readonly EFDbContext _context;
        private readonly DbSet<T> _dbSet;
        private readonly ITennantContext TennantContext;
        public EFCoreRepository(EFDbContext context, ITennantContext TennantContext)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            this.TennantContext = TennantContext;
        }
        public IQueryable<T> All
        {
            get
            {
                // if(T is tennantentity)
                // apply tennant filter
                return _dbSet.AsQueryable<T>();
            }
        }


        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.Remove(entity);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public T SelectById(int Id)
        {
            return this.All.FirstOrDefault(m => m.Id == Id);
        }

        public void Save(T entity)
        {
            if (entity.Id > 0)
            {
                Update(entity);
            }
            else
            {
                Insert(entity);
            }
        }

        public void Delete(IList<T> entity)
        {
            foreach (var item in entity)
            {
                this.Delete(item);
            }
        }

        private void Insert(T entity)
        {
            _dbSet.Add(entity);
        }
        private void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
