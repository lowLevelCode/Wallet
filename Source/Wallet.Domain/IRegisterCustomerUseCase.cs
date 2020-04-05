namespace Wallet.Domain
{
    public interface IRegisterCustomerUseCase
    {
         CustomerResult Register(string expectName, string expectPhone);
    }
}