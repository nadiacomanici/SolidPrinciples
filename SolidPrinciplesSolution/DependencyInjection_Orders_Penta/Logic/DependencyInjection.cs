using System;
using Autofac;
using DependencyInjection_Orders_Penta.Logic.Implementations;

namespace DependencyInjection_Orders_Penta.Logic
{
    public static class DependencyInjection
    {

        public static IContainer Container { get; private set; }
        static DependencyInjection()
        { 
       
            var builder = new ContainerBuilder();

            // Register individual components
            //builder.RegisterInstance(new TaskRepository())
            //.As<ITaskRepository>();
            //builder.RegisterType<TaskController>();
            //builder.Register(c => new LogManager(DateTime.Now))
            //       .As<ILogger>();
            //
            //// Scan an assembly for components
            //builder.RegisterAssemblyTypes(myAssembly)
            //       .Where(t => t.Name.EndsWith("Repository"))
            //       .AsImplementedInterfaces();

            builder.RegisterInstance(new NotificationService()).As<INotificationService>();
            builder.RegisterInstance(new PaymentProcessor()).As<IPaymentProcessor>();
            builder.RegisterInstance(new ReservationService()).As<IReservationService>();


            Container = builder.Build();
        }
    }
}
