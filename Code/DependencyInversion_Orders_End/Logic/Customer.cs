namespace DependencyInversion_Orders_End.Logic
{
    public class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

        public Customer(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
    }
}
