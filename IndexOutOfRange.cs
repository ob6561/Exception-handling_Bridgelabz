using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class IndexOutOfRange
    {
        static void Main()
        {
            int[] arr = { 10, 20, 30 };

            try
            {
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index not found in array!");
            }
        }
    }
}
