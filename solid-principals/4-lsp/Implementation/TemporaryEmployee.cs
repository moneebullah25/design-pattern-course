using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid_principals._4_lsp.Abstract;

namespace solid_principals._4_lsp.Implementation
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        { }

        public TemporaryEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .05M);
        }

        public override decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
