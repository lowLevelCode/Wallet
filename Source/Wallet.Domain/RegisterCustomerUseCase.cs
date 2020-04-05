namespace Wallet.Domain
{
    public class RegisterCustomerUseCase : IRegisterCustomerUseCase
    {
        public CustomerResult Register(string expectName, string expectPhone)
        {
            return new CustomerResult(new Customer(expectName,expectPhone));
        }
    }
}