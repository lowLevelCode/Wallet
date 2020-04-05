using System;
using Wallet.Domain;
using Xunit;

namespace Wallet.UnitTest
{
    public class CustomerTests
    {
        [Fact]
        public void Register_customer()
        {
            //Given
            string expectName = "Jonh";
            string expectPhone = "+52 6672923923";
            IRegisterCustomerUseCase register = new RegisterCustomerUseCase();

            //When            
            CustomerResult customer = register.Register(expectName,expectPhone);

            //Then
            Assert.NotNull(customer);
            Assert.NotEqual(Guid.Empty, customer.Id);
            Assert.Equal(expectName, customer.Name);
            Assert.Equal(expectPhone,customer.Phone);
        }
        
        [Fact]
        public void Customer_create()   
        {
            //Given
            string expectName = "Jonh";
            string expectPhone = "+52 6672923923";

            //When
            Customer customer = new Customer(expectName, expectPhone);
            
            //Then
            Assert.NotNull(customer);
            Assert.NotEqual(Guid.Empty, customer.Id);
            Assert.Equal(expectName, customer.Name);
            Assert.Equal(expectPhone,customer.Phone);   
        }
    }
}