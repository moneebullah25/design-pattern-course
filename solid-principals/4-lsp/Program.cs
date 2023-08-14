using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid_principals._4_lsp.Abstract;
using solid_principals._4_lsp.Implementation;
using solid_principals._4_lsp.Interface;

namespace solid_principals._4_lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TemporaryEmployee(2, "Jason"));
            //Un Comment to see the error
            //employees.Add(new ContractEmployee(3, "Mike"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
                employee.ToString(),
                employee.CalculateBonus(100000).ToString(),
                employee.GetMinimumSalary().ToString()));
            }

            Console.WriteLine();

            List<IEmployee> employeesOnly = new List<IEmployee>();

            employeesOnly.Add(new PermanentEmployee(1, "John"));
            employeesOnly.Add(new TemporaryEmployee(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3, "Mike"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumSalary().ToString()));
            }
            Console.ReadLine();
        }
    }
}
