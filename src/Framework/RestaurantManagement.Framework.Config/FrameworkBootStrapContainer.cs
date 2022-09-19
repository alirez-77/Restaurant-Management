using Autofac;
using BRE.Framework.Config.Interceptors;

namespace BRE.Framework.Config
{
    public class FrameworkBootStrapContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TransactionInterceptor>().AsSelf().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}