using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public class AddressDetails : IAddress
    {
        public Models.Address GetAddressDetails(int userID)
        {
            Console.WriteLine("\t SubSystem Address : GetAddressDetails");
            return new Models.Address();
        }

    }
}
