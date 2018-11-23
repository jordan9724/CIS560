using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560
{
    /// <summary>
    /// An object representing an address
    /// </summary>
    public class Address
    {
        public int addressId { get; }
        public string line1 { get; }
        public string line2 { get; }
        public string city { get; }
        public string state { get; }
        public int zip { get; }

        public Address(int addressId, string line1, string line2, string city, string state, int zip)
        {
            this.addressId = addressId;
            this.line1 = line1;
            this.line2 = line2;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }
    }
}
