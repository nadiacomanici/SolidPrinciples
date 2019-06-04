using DependencyInjection_Orders_End.Logic.Carts;
using DependencyInjection_Orders_End.Logic.Contracts;
using DependencyInjection_Orders_End.Logic.Implementations;

namespace DependencyInjection_Orders_End.Logic.Orders
{
    public class POSCreditOrder : Order
    {
        private readonly CreditCard paymentDetails;
        private readonly IPaymentProcessor paymentProcessor;

        public POSCreditOrder(Cart cart, Customer customer, CreditCard paymentDetails)
            : base(cart, customer)
        {
            this.paymentDetails = paymentDetails;
            this.reservationService = new ReservationService();
            this.paymentProcessor = new PaymentProcessor();
        }

        public override void Checkout()
        {
            paymentProcessor.ProcessCreditCard(paymentDetails, cart);
            base.Checkout();
        }
    }
}
