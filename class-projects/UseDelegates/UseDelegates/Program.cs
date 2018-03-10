using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDelegates
{
    // this delegateis pointing to the method that returns a void, 
    // and this method delegate points to the parameter of string
    delegate void MyDelegate(string input);
   
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate aDelegateObject = new MyDelegate(SomeMethods.Method4);

            // aDelegateObject took the place of Method4
            aDelegateObject("Data from aDelegatObject...");
            aDelegateObject.Invoke("more data from aDelegateObject... ");

            SomeMethods someMethodsInstance = new SomeMethods();

            // this time, we point to the differetn method (replacement from Method4 to Method1)
            aDelegateObject = new MyDelegate(someMethodsInstance.Method1);
            aDelegateObject("data from Method1 delegate...");

            // multi-threading 
            aDelegateObject = new MyDelegate(SomeMethods.Method4);
            aDelegateObject += new MyDelegate(someMethodsInstance.Method1);
            aDelegateObject += new MyDelegate(someMethodsInstance.Method5);
            aDelegateObject("how many methods get invoked by the delegate");

            aDelegateObject -= new MyDelegate(someMethodsInstance.Method1);
            aDelegateObject("how many methods this time get invoked by the delegate");


            Console.WriteLine("\nPress <Enter> to quit...");
            Console.ReadKey();

        }
    }
}
