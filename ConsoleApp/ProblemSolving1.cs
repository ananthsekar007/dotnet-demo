using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ProblemSolving1
    {
        public static void Main(string[] args)
        {
            StringOperation stringOperation = new(Console.ReadLine());
            Console.WriteLine(stringOperation.ExchangeString());
        }
    }

    internal class StringOperation
    {
        string firstString;
        public StringOperation(string firstString)
        {
            this.firstString = firstString;
        }

        public string ExchangeString() {
            return firstString.ElementAt(firstString.Length - 1) + firstString.Substring(1,firstString.Length - 2) + firstString.ElementAt(0);
        }
    }
}
