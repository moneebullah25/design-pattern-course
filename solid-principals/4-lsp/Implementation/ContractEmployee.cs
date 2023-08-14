using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid_principals._4_lsp.Interface;

namespace solid_principals._4_lsp.Implementation
{
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public ContractEmployee()
        { }

        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
}
