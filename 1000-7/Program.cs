using System;
using System.Timers;

namespace wtf_man
{
    class Program
    {
        static int oneThousand = 1000;
        static int currenValue = 0;
        static int increment = 7;
        static Timer halfSeconTimer;
        static void Main(string[] args)
        {
            SetTimer();

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.ReadLine();
            halfSeconTimer.Stop();
            halfSeconTimer.Dispose();

            Console.WriteLine("Terminating the application...");
        }


        public static void SetTimer()
        {
            halfSeconTimer = new System.Timers.Timer(0.1);
            halfSeconTimer.Elapsed += OnTimedEvent;
            halfSeconTimer.AutoReset = true;
            halfSeconTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (oneThousand > 2)
            {
                currenValue = oneThousand - increment;
                Console.WriteLine(oneThousand + " - " + increment + " = " + currenValue);
                oneThousand = currenValue;
            }
            else
            {
                halfSeconTimer.Stop();
                Console.WriteLine("Done!");
                Console.ReadKey();
            }
        }

    }
}