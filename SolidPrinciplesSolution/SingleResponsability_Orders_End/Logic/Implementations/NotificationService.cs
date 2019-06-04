using System;

namespace SingleResponsability_Orders_End.Logic.Implementations
{
    public class NotificationService
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
