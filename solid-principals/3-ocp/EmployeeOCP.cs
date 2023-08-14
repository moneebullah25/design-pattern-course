using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principals._3_ocp
{
    // EmployeeOCP class is open for extension but it is closed for modification
    public abstract class EmployeeOCP
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public EmployeeOCP()
        {
        }
        public EmployeeOCP(int id, string name)
        {
            this.ID = id; this.Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }

    public class PermanentEmployee : EmployeeOCP
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporaryEmployee : EmployeeOCP
    {
        public TemporaryEmployee()
        { }

        public TemporaryEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}
