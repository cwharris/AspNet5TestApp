using Autofac;
using Mvc5TestApp.Services;

namespace Mvc5TestApp
{
    public class StartupModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthMessageSender>()
                .As<IEmailSender>()
                .As<ISmsSender>();
        }
    }
}