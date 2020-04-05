using System;

namespace Wallet.Domain
{
    public class CustomerResult
    {
        public CustomerResult(Customer customer)
        {
            this.Id = customer.Id;
            this.Name = customer.Name;
            this.Phone = customer.Phone;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string  Phone { get; set; }
    }
}