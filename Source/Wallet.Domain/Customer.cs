using System;

namespace Wallet.Domain
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }

        public Customer(string name, string phone)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Phone = phone;
        }
    }
}