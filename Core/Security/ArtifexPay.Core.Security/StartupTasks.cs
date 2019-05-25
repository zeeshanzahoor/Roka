using Autofac;
using Microsoft.AspNetCore.Http;
using ArtifexPay.Backbone.Security;
using ArtifexPay.Backbone.Services;
using ArtifexPay.Core.Security.Internals;

namespace ArtifexPay.Core.Security
{
    internal class StartupTasks : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DefaultAuthenticationProvider>().As<IAuthenticationProvider>().InstancePerLifetimeScope();
            builder.RegisterType<JwtTokenGenerator>().As<ITokenGenerator>().InstancePerLifetimeScope();
            builder.RegisterType<UserContext>().As<IUserContext>().InstancePerLifetimeScope();
            builder.RegisterType<TennantContext>().As<ITennantContext>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
