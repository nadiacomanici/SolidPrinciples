namespace SingleResponsability_Orders_End.Logic.Contracts
{
    public interface INotificationService
    {
        void NotifyCustomer(Cart cart, Customer customer);
    }
}
