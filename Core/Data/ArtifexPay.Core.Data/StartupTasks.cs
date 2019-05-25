using Autofac;
using ArtifexPay.Backbone.Data.Repository;
using ArtifexPay.Core.Data.Internals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Core.Data
{
    internal class StartupTasks : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EFDbContext>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(EFCoreRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
