using Autofac;
using ArtifexPay.Backbone.Audit;
using Roka.Core.Audit.Internals;

namespace Roka.Core.Audit
{
    internal class StartupTask : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SimpleAuditLogger>().As<IAuditLogger>().InstancePerLifetimeScope();
            //builder.RegisterType<NullAuditLogger>().As<IAuditLogger>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
