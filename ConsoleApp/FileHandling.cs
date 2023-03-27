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
            using (TextWriter textWriter = File.CreateText(path))
            {
                char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
                textWriter.WriteLine(charArray, 2, 3);
            }

            using (TextReader textReader =  File.OpenText(path))
            {
                Console.WriteLine(textReader.Read());
            }

            FileStream fileStream = new(path, FileMode.Open, FileAccess.Write);
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine("writing in text file");
                writetext.Close();
                fileStream.Close();
            }

            using (StreamReader readtext = new StreamReader(path))
            {
                Console.WriteLine(readtext.ReadLine());
                readtext.Close();
                fileStream.Close();
            }
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine("writing in text file");
                writetext.Close();
                fileStream.Close();
            }

            using (StreamReader readtext = new StreamReader(path))
            {
                Console.WriteLine(readtext.ReadLine());
                readtext.Close();
                fileStream.Close();
            }
        }

        
    }
}
