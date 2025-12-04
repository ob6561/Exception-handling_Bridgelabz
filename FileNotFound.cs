using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class FileNotFound
    {
        static void Main()
        {
            try
            {
                string data = File.ReadAllText("sample.txt");
                Console.WriteLine(data);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
        }
    }
}
