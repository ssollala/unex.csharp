using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDelegates
{
    public class SomeMethods
    {
        public void Method1(string data)
        {
            Console.WriteLine("Method1 has this data: {0}", data);
        }
        public string Method2(string data)
        {
            Console.WriteLine("Method2 has this data: {0}", data);
            return "Method2 processed data.";
            
        }
        public void Method3(string data, int moreData)
        {
            Console.WriteLine("Method3 has this data: {0}, {1}", data, moreData );
        }
        public static void Method4(string data)
        {
            Console.WriteLine("Method4 has this data: {0}", data);
        }
        public void Method5(string data)
        {
            Console.WriteLine("Method5 has this data: {0}", data);
        }

    }
}
