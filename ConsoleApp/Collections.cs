using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Collections
    {
        public void Main(string[] args)
        {

            //Collections.DisplayUnique();
            Collections.MergeArrays();
            Collections.SeperateOddAndEven();

        }

        public void DisplayUnique()
        {
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            List<int> numberArray = new List<int>();
            for (int i = 0; i < arrayLength; i++)
            {
                numberArray.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Dictionary<int, int> uniqueCount = new Dictionary<int, int>();

            foreach (int i in numberArray)
            {
                if (uniqueCount.ContainsKey(i))
                {
                    uniqueCount[i]++;
                }
                else
                {
                    uniqueCount[i] = 1;
                }
            }

            foreach (var i in uniqueCount)
            {
                Console.WriteLine($"Count of {i.Key} is {i.Value}");
            }
        }

        public static void MergeArrays()
        {
            Console.WriteLine("Enter the size of the arrays : ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of first array :");
            int[] firstArray = new int[arrayLength*2];
            for(int i = 0; i < arrayLength; i++)
            {
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            };
            Console.WriteLine("Enter the values of Second array :");
            int[] secondArray= new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                secondArray[i] = Convert.ToInt32(Console.ReadLine());
            };
            for(int i = arrayLength; i<arrayLength * 2; i++)
            {
                firstArray[i] = secondArray[i - arrayLength];
            }

            Array.Sort(firstArray);

            Console.WriteLine("After sorting...");
            foreach(int i in firstArray)
            {
                Console.Write(i);
            }
        }

        public static void SeperateOddAndEven()
        {
            int[] numericArray = new int[5] {1,2,3,4,5};

            List<int> OddList = new();
            List<int> EvenList = new();

            foreach(int i in numericArray)
            {
                if(i % 2 == 0)
                {
                    EvenList.Add(i);
                }
                else
                {
                    OddList.Add(i);
                }
            }

            OddList.ForEach((value) => Console.WriteLine(value));
            Console.WriteLine(string.Join(", ", EvenList));
        }
    }
}
