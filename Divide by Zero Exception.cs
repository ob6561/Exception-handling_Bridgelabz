using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Divide_by_Zero_Exception
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());

                int result = num / 0;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }
    }
}
