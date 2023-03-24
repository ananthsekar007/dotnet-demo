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
            Console.WriteLine(stringOperation.AddCharAtFrontAndEnd());
            Console.WriteLine(stringOperation.RemoveOkFromString());
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

        public string AddCharAtFrontAndEnd()
        {
            if (firstString.Length < 1) {
                Console.WriteLine("The string length should be greater than 1");
                return "";
             }
            var lastChar = firstString.ElementAt(firstString.Length - 1);
            return  lastChar+ firstString + lastChar;
        }

        public string RemoveOkFromString()
        {
            string outStr = this.firstString;
            while(outStr.Contains("ok", StringComparison.OrdinalIgnoreCase))
            {

                outStr = outStr.Replace("ok", "", StringComparison.OrdinalIgnoreCase);
            }
            return outStr;
        }
    }
}
