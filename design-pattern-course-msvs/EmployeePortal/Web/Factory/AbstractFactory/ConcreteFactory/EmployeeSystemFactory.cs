using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.Factory.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returnValue = null;
            if (e.EmployeeTypeID == 1)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new MACLaptopFactory();
                }
                else
                {
                    returnValue = new MACFactory();
                }
            }
            else if (e.EmployeeTypeID == 2)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                    returnValue = new DellFactory();
            }
            return returnValue;
        }
    }
}