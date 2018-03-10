using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUsage
{
    public class Utilities
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("Swap() method is processing a " + typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
