using CompositeDesignPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Composite
{
    public class Manager : IEmployee
    {
        public List<IEmployee> SubOrdinates;
        public Manager(string name, string dept)
        {
            this.Name = name;
            this.Department = dept;
            SubOrdinates = new List<IEmployee>();
        }
        public string Name { get; set; }
        public string Department { get; set; }
        public void GetDetails(int indentation)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("{0}+ Name:{1}, " +
                "Dept:{2} - Manager(Composite)",
                new String('-', indentation), this.Name.ToString(),
                this.Department));
            foreach (IEmployee component in SubOrdinates)
            {
                component.GetDetails(indentation + 1);
            }
        }
    }
}