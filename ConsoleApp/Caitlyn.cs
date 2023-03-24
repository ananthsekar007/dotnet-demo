using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Caitlyn
    {
        public static void Main(string[] args)
        {
            ChocolateDispenser chocolateDispenser = new ChocolateDispenser();

            chocolateDispenser.AddChocolates("RED", 2);
            chocolateDispenser.AddChocolates("BLUE", 4);
            List<string> dispensedChocolates = chocolateDispenser.DispenseChocolates(3);
            List<string> removedChocolates = chocolateDispenser.RemoveChocolates(3);
            foreach(string s in dispensedChocolates)
            {
                Console.WriteLine($"Dispensed chocolate - {s}");
            }
            foreach(string s in removedChocolates)
            {
                Console.WriteLine($"Removed chocolate = {s}");
            }
        }
    }

    internal class ChocolateDispenser
    {
        LinkedList<string> chocolateDispenser;

        public void AddChocolates(string color, int count)
        {
            for(int i = 0; i < count; i++)
            {
                chocolateDispenser.AddLast(color);
            }
        }

        public List<string> RemoveChocolates(int count) {

            List<string> removedChocolates = new();
        
            for(var i = 0; i < count;i++)
            {
                removedChocolates.Add(removedChocolates.Last());
                chocolateDispenser.RemoveLast();
            }
            return removedChocolates;
        }

        public List<string> DispenseChocolates(int count)
        {
            List<string> dispensedChocolates = new();
            for(int i = 0; i < count; ++i)
            {
                dispensedChocolates.Add(chocolateDispenser.First());
                chocolateDispenser.RemoveFirst();
            }
            return dispensedChocolates;

        }
    }
}
