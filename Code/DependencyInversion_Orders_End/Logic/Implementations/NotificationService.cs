using System;
using System.Net.Mail;
using DependencyInversion_Orders_End.Logic.Carts;
using DependencyInversion_Orders_End.Logic.Contracts;

namespace DependencyInversion_Orders_End.Logic.Implementations
{
    public class NotificationService : INotificationService
    {
        public void NotifyCustomer(Cart cart, Customer customer)
        {
            if (!string.IsNullOrEmpty(customer.Email))
            {
                try
                {
                    using (var message = new MailMessage("orders@email.com", customer.Email))
                    {
                        using (var client = new SmtpClient("localhost"))
                        {
                            message.Subject = $"Your order placed on {DateTime.Now}";
                            message.Body = $"Your order details: {cart}";
                            client.Send(message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error("Problem sending email", ex);
                    //throw;
                }
            }
        }
    }
}
