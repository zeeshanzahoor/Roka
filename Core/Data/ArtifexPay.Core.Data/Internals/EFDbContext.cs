using Microsoft.EntityFrameworkCore;
using ArtifexPay.Backbone.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ArtifexPay.Backbone.Security;

namespace ArtifexPay.Core.Data.Internals
{
    internal class EFDbContext : DbContext
    {
        private const string AssemblyPath = "ArtifexPay.Backbone";
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly Assembly = AppDomain.CurrentDomain.GetAssemblies()
                .FirstOrDefault(assembly => assembly.GetName().Name == AssemblyPath);

            MethodInfo EntityMethod = typeof(ModelBuilder).GetMethods()
                .Where(m => m.Name.Equals("Entity"))
                .Where(m => m.GetParameters().Count() == 0)
                .First();

            Assembly.GetTypes()
                 .Where(m => m.BaseType != null)
                 .Where(m => m.BaseType.Name.Equals("BaseEntity")).ToList()
                 .ForEach(m => EntityMethod.MakeGenericMethod(m).Invoke(modelBuilder, new object[] { }));

        }
        private readonly ITennantContext _tennantContext;
        public EFDbContext(ITennantContext TennantContext)
        {
            _tennantContext = TennantContext;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IDbConnection connection = new SqlConnection(_tennantContext.ConnectionString);
            optionsBuilder.UseSqlServer((DbConnection)connection);
        }
    }
}
