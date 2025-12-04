using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class AgeException : Exception
    {
        public AgeException(string message) : base(message) { }
    }
    internal class Custom_Exception
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 18)
                    throw new AgeException("Age must be 18 or above.");

                Console.WriteLine("Valid age!");
            }
            catch (AgeException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
        }
    }
}
