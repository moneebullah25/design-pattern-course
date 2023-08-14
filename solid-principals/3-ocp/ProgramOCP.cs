using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principals._3_ocp
{
    class ProgramOCP
    {
        static void Main(string[] args)
        {
            EmployeeOCP empJohn = new PermanentEmployee(1, "John");
            EmployeeOCP empJason = new TemporaryEmployee(2, "Jason");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJohn.ToString(),
                empJohn.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              empJason.ToString(),
              empJason.CalculateBonus(150000).ToString()));
            Console.ReadLine();
        }
    }
