using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Multiple_Catch_Blocks
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter number: ");
                int n = int.Parse(Console.ReadLine());

                int result = 100 / n;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
