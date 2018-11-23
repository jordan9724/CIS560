using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560
{
    /// <summary>
    /// An object representing a customer
    /// </summary>
    public class Customer
    {
        public int customerId { get; }
        public string firstName { get; }
        public string lastName { get; }
        public int primaryAddressId { get; }
        public string email { get; }
        public int phoneNumber { get; }

        public Customer(int customerId, string firstName, string lastName, int primaryAddressId, string email, int phoneNumber)
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.primaryAddressId = primaryAddressId;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
    }
}
