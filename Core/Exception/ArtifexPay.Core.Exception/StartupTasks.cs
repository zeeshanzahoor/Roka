using Autofac;
using ArtifexPay.Backbone.Exception;
using ArtifexPay.Core.Exception.Internals;

namespace ArtifexPay.Core.Exception
{
    internal class StartupTasks : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ExceptionHandler>().As<IExceptionHandler>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
