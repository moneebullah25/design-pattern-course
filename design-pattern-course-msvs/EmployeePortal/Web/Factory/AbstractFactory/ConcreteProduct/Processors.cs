using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Web.Factory.AbstractFactory.Enumerations;

namespace Web.Factory.AbstractFactory
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I7.ToString();
        }
    }
    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I5.ToString();
        }
    }
}