using Autofac;
using Autofac.Extras.DynamicProxy;
using BRE.Framework.Config.Interceptors;
using BRE.Ticket.Framework.Domain.Contracts.ApplicationService;
using RestaurantManagement.Appliation.CommandService.Food;
using RestaurantManagement.Framework.Contract;
using RestaurantManagement.Persistence.EF.Implementation;

namespace RestaurantManagement.Config;

public class BootstrapContainer : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypes(typeof(FoodApplicationCommandService).Assembly)
            .Where(a => typeof(IApplicationCommandService).IsAssignableFrom(a))
            .AsImplementedInterfaces()
            .EnableInterfaceInterceptors()
            .InterceptedBy(typeof(TransactionInterceptor))
            .InstancePerLifetimeScope();

        builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

        base.Load(builder);
    }
}