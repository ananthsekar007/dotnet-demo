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
    }
    internal class Struct
    {
        public static void Main(string[] args)
        {
            Age age = new Age();
            age.PersonAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The age of the person is {age.PersonAge}");

        }
        
    }
}
