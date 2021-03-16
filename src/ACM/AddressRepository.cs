using System;
using System.Collections.Generic;

namespace ACM
{
    public class AddressRepository
    {
        // Retrieve one address
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Miggrade";
                address.StreetLine2 = "Mid lane";
                address.City = "Nairobi";
                address.State = "Westward";
                address.Country = "Kenya";
                address.PostalCode = "124";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            var address = new Address()
            {
                AddressType = 1,
                StreetLine1 = "Miggrade",
                StreetLine2 = "Mid lane",
                City = "Nairobi",
                State = "Westward",
                Country = "Kenya",
                PostalCode = "124",
            };
            addressList.Add(address);

            var address2 = new Address()
            {
                AddressType = 1,
                StreetLine1 = "Big brigade",
                StreetLine2 = "Brow lane",
                City = "Nambale",
                State = "yardling",
                Country = "Kenya",
                PostalCode = "365",
            };
            addressList.Add(address2);

            return addressList;
        }

        // Save product
        public bool Save(Address address)
        {
            return true;
        }
    }
}
