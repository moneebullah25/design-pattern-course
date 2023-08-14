using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SingletonDemo
{
    // sealed keyword to avoid inheritance and class chaining
    public sealed class Singleton
    {
        private static int counter = 0;
       
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        // When eager loading is done we can use LAzy keyword which provides default behaiour of lazy initialization
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());
       
        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
       
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }       
    }
}