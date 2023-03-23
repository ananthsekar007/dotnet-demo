using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    struct Age
    {
        public int age;
        public int PersonAge
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void call()
        {
            Console.WriteLine("Function call");
        }
    }
    internal class Struct
    {
        public static void Main(string[] args)
        {
            Age age = new()
            {
                PersonAge = 1
            };

            age.call();

            

            Console.WriteLine($"The age of the person is {age.PersonAge}");

        }
        
    }
}
