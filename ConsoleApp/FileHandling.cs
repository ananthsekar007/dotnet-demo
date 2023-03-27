using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class FileHandling
    {
        public static void Main(string[] args) {
            Console.WriteLine("File Handling!");
            using (StreamWriter writetext = new StreamWriter("C:\\Users\\Hp\\Documents\\file.txt"))
            {
                writetext.WriteLine("writing in text file");
            }
        }
    }
}
