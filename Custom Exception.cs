using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exception_handling
{
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message) { }
    }
    public class Custom_Exception
    {
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new AgeException("You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Age accepted.");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                CheckAge(age);
            }
            catch (AgeException ex)
            {
                Console.WriteLine("Custom Exception Caught!");
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Finished.");
            }
        }
        
    }
}
