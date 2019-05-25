using ArtifexPay.Backbone.Services;
using ArtifexPay.Services.Internals;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Services
{
    internal class StartupTask : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Assembly CurrentAssembly = Assembly.GetAssembly(typeof(StartupTask));

            builder.RegisterAssemblyTypes(CurrentAssembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterType(typeof(UserService)).As(typeof(IUserService)).InstancePerLifetimeScope();



            base.Load(builder);
        }
    }
}
