using Autofac;
using ArtifexPay.Backbone.Cache;
using ArtifexPay.Core.Cache.Internals;

namespace ArtifexPay.Core.Cache
{
    internal class StartupTasks : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RuntimeCacheStorage>().As<ICacheStorage>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
