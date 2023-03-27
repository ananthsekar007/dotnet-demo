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
            const string path = "C:\\Users\\Hp\\Documents\\file.txt";
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine("writing in text file");    
            }

            using (StreamReader readtext = new StreamReader(path))
            {
                Console.WriteLine(readtext.ReadLine());
            }
        }
    }
}
