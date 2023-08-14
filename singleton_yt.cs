using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// First Singleton version
/// </summary>
namespace SingletonDemo
{
    /*
     *  Sealed restricts the inheritance
     */
    public class Singleton
    {
        private static int counter = 0;
        private static object obj = new object();
        /*
        * Private constructor ensures that object is not
        * instantiated other than with in the class itself
        */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static Singleton instance = null;
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        /*
         * By removing sealed keyword we can inherit the singleton and instantiate multiple objects
         * This violates singleton design principles.
         */
        public class DerivedSingleton : Singleton
        {
        }
    }
}

// What is a nested class? 
// A class with in another class is called a nested class. 
// Now that we have moved the derived class to nested class lets compile the program and check. Look at that we are able to compile this successfully. 
// Now, let’s switch to main program and access the nested class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// First version of Singleton demo
/// </summary>
namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Assuming Singleton is created from student class
            * we refer to the GetInstance property from the Singleton class
            */
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            /*
            * Assuming Singleton is created from employee class
            * we refer to the GetInstance property from the Singleton class
            */
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");

            Console.WriteLine("-------------------------------------");
            /*
             * Instantiating singleton from a derived class. This violates singleton pattern principles.
             */
            Singleton.DerivedSingleton derivedObj = new Singleton.DerivedSingleton();
            derivedObj.PrintDetails("From Derived");
          
            Console.ReadLine();
        }
    }
}

// Lets run the program. Look at that the counter value has incremented to 2 proving that we are able to create multiple instances of the singleton using the nested derived class.
// This violates the principle of singleton.  Let’s go back to the Singleton and make the class as sealed. Let’s compile the program
// Look at that we have got an error when we compile the program saying we cannot derive a sealed class. With this we have proved that private constructor helps in preventing any external instantiations of objects and sealed will prevent the class inheritances.