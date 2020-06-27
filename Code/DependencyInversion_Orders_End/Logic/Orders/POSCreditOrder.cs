using DependencyInversion_Orders_End.Logic.Carts;
using DependencyInversion_Orders_End.Logic.Contracts;

namespace DependencyInversion_Orders_End.Logic.Orders
{
    public class POSCreditOrder : Order
    {
        private readonly CreditCard _creditCard;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IReservationService _reservationService;

        public POSCreditOrder(Cart cart, Customer customer, CreditCard paymentDetails,
            IPaymentProcessor paymentProcessor, IReservationService reservationService)
            : base(cart, customer)
        {
            _creditCard = paymentDetails;
            _paymentProcessor = paymentProcessor;
            _reservationService = reservationService;
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_creditCard, _cart);
            _reservationService.ReserveInventory(_cart);
        }
    }
}
