using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace UseTimer_EventBased
{
    class Program
    {
        public static Timer aTimer;

        static void Main(string[] args)
        {
            SetTimer();

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();
            Console.WriteLine("Terminating the application...");
        }

        public static void SetTimer()
        {

            // Create a timer with a two second interval.
            aTimer = new Timer(2000);

            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += OnTimedEvent;

            // The true value on the AutoReset property makes a reoccurring event
            aTimer.AutoReset = true;
            aTimer.Enabled = true; // enable the timer
        }

        private static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
            e.SignalTime);
        }

    }
}
