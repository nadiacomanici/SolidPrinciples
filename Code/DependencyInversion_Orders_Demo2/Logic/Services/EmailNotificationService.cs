using System;

namespace SingleResponsability_Orders_Demo.Logic.Services
{
    public class EmailNotificationService : IEmailNotificationService
    {
        public void NotifyCustomer()
        {
            Console.WriteLine("NotifyCustomer");
        }
    }
}
