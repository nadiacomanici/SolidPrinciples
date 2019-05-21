using System;
using SingleResponsability_Orders_End.Logic.Contracts;

namespace SingleResponsability_Orders_End.Logic.Implementations
{
    public class NotificationService : INotificationService
    {
        public void NotifyCustomer(Cart cart, Customer customer)
        {
            Console.WriteLine("NotifyCustomer");
            if (!string.IsNullOrEmpty(customer.Email))
            {
                // send email
            }
        }
    }
}
