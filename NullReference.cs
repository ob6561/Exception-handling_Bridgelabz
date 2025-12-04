using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class NullReference
    {
        static void Main()
        {
            string name = null;

            try
            {
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Object reference is null!");
            }
        }
    }
}
