using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Orders_Penta.Logic
{
    public class EmailNotifier
    {
        public void NotifyCustomer(Customer customer)
        {
            Console.WriteLine("NotifyCustomer");
            if (!string.IsNullOrEmpty(customer.Email))
            {
                // send email
            }
        }
    }
}
