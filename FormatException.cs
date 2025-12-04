using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class FormatException
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter an integer: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered: " + num);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numbers only.");
            }
        }
    }
}
