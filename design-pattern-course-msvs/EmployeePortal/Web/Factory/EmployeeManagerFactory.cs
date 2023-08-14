using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;

namespace Web.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeId)
        {
            IEmployeeManager r = null;
            if (employeeId == 1) r = new PermanentEmployeeManager();
            else if (employeeId == 2) r = new ContractEmployeeManager();
            return r;
        }
    }
}