using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Web.Factory.AbstractFactory.Enumerations;

namespace Web.Factory.AbstractFactory
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Brands.APPLE.ToString();
        }
    }
}