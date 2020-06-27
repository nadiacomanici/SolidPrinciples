using SingleResponsability_Orders_End.Logic.Implementations;

namespace SingleResponsability_Orders_End.Logic.Orders
{
    public class POSCreditOrder : Order
    {
        private readonly CreditCard _creditCard;
        private readonly PaymentProcessor _paymentProcessor;
        private readonly ReservationService _reservationService;

        public POSCreditOrder(Cart cart, Customer customer, CreditCard paymentDetails)
            : base(cart, customer)
        {
            _creditCard = paymentDetails;
            _reservationService = new ReservationService();
            _paymentProcessor = new PaymentProcessor();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_creditCard, _cart);
            _reservationService.ReserveInventory(_cart);
        }
    }
}
