using SingleResponsability_Orders_End.Logic.Contracts;
using SingleResponsability_Orders_End.Logic.Implementations;

namespace SingleResponsability_Orders_End.Logic.Orders
{
    public class POSCreditOrder : Order
    {
        private readonly CreditCardPaymentDetails paymentDetails;
        private readonly IPaymentProcessor paymentProcessor;

        public POSCreditOrder(Cart cart, Customer customer, CreditCardPaymentDetails paymentDetails)
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
