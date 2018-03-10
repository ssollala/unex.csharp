using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASynchFibonacci_DasolKwon
{
    public delegate int Calculate(int n);
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("--Calculate a Fibonacci number at a certain position (0-49)--");
            char answer;

            do
            {
                Console.Write("\nEnter a position to compute: ");
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num < 0 || num > 49)
                    {
                        Console.WriteLine("ERROR: Position should be an integer from 0 to 49.");
                    }
                    else
                    {
                        Calculate c = new Calculate(Fibonacci);
                        IAsyncResult iasResult = c.BeginInvoke(num, null, null);

                        // This message will keep printing until
                        // the Fibonacci() method is finished.
                        while (!iasResult.IsCompleted)
                        {
                            Console.WriteLine("Main() invoked on thread {0}.",
                                    Thread.CurrentThread.ManagedThreadId);
                            Console.WriteLine("continuing to do work...");
                            Thread.Sleep(1000);
                        }

                        int result = c.EndInvoke(iasResult);
                        Console.WriteLine($"Fibonacci value at position {num}: {result}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: A position should be an integer.");
                }
                finally
                {  
                    Console.Write("Do you want to continue? (Y or N) ");
                    answer = Convert.ToChar(Console.ReadLine());
                }
            } while (answer == 'y' || answer == 'Y');

            Console.WriteLine("\nProgram Ended");

            Console.WriteLine("\nPress <Enter> to quit...");
            Console.ReadKey();
        }

        private static int Fibonacci(int n)
        {
            // Print out the ID of the executing thread.
            Console.WriteLine("Fibonacci() invoked on thread {0}.",
            Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(5000);
            // calculate a fiboniacci number at position n
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                 int temp = a;
                 a = b;
                 b = temp + b;
            }
            return a;
            
        }
    }
}

