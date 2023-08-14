
using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public class Wallet : IWallet
    {
        public double GetUserBalance(int userID)
        {
            Console.WriteLine("\t SubSystem Wallet : GetUserBalance");
            return 100;
        }
    }
}