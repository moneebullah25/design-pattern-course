using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principals._4_lsp.Interface
{
    interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
