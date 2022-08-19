using Autofac;
using DependencyInversion_Orders_End.Logic.Contracts;
using DependencyInversion_Orders_End.Logic.Implementations;
using DependencyInversion_Orders_End.Logic.Inventories;

namespace DependencyInversion_Orders_End
{
    class Program
    {
        private static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>();
            builder.RegisterType<InventorySystem>().SingleInstance(); 
            builder.RegisterType<NotificationService>().As<INotificationService>();
            builder.RegisterType<PaymentProcessor>().As<IPaymentProcessor>();
            builder.RegisterType<ReservationService>().As<IReservationService>().PropertiesAutowired();

            return builder.Build();
        }

        static void Main(string[] args)
        {
            CompositionRoot().Resolve<Application>().Run();
        }
    }
}
