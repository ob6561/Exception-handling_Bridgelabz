using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Finally_Block_Demonstration
    {
        static void Main()
        {
            try
            {
                int x = int.Parse("abc");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred!");
            }
            finally
            {
                Console.WriteLine("Finally block always executes.");
            }
        }
    }
}
