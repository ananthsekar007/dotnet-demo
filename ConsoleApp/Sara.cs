using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Sara
    {
        public void Main(string[] args)
        {
            List<PsychTest> resultList = new List<PsychTest>();
            while (true)
            {
                
                Console.Write("What is Your name? : ");
                string name = Console.ReadLine();
                Console.Write("Enter your DOB - (format - YYYY/MM/DD) : ");
                DateTime dob = Convert.ToDateTime(Console.ReadLine());
                Console.Write("What is your Zodiac sign ? : ");
                string zodiacSign = Console.ReadLine();
                PsychTest psychTest = new PsychTest(dob, name, zodiacSign);
                resultList.Add(psychTest);
                Console.WriteLine("If you want to stop adding the information, enter \"end\" else enter \"continue\"");
                if (Console.ReadLine() == "end") break;
            }

            foreach(PsychTest person in resultList)
            {
                person.DisplayInformation();
                person.CalculateCurrentAge();
            }

        }
    }

    internal class PsychTest
    {
        DateTime dob;
        string name;
        string zodiacSign;

        public PsychTest(DateTime dob, string name, string zodiacSign)
        {
            this.dob = dob;
            this.name = name;
            this.zodiacSign = zodiacSign;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Friend Name id {this.name}, date of birth is {this.dob.ToString("MM/dd/yyyy")} and the zodiac sign is {this.zodiacSign}");
        }

        public void CalculateCurrentAge()
        {
            int age = 0;
            age = DateTime.Now.Year - this.dob.Year;
            if (DateTime.Now.DayOfYear < this.dob.DayOfYear)
                age = age - 1;

            Console.WriteLine($"{this.name}, your age is {age}");
        }
    }

}
