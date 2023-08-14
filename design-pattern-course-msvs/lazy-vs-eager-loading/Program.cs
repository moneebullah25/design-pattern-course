using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lazy_vs_eager_loading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run two thread in Parralel to created dummy multithreaded enviroment
            Parallel.Invoke(
                () => PrintStudentDetails(), // labda function
                () => PrintEmployeeDetails()
            );
            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
