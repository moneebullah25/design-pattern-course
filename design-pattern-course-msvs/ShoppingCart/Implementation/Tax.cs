using ShoppingCart.Interfaces;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public class Tax : ITax
    {
        public void ApplyTax(int cartID, double taxPercent)
        {
            Console.WriteLine("\t SubSystem Tax : ApplyTax");
        }
        public double GetTaxByState(string state)
        {
            Console.WriteLine("\t SubSystem Tax : GetTaxByState");
            return 10;
        }
    }
}