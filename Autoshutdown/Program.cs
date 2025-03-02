using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            DateTime now = DateTime.Now;
            Console.Clear();
            Console.WriteLine("Current Time: " + now.ToString("hh:mm:ss tt"));

            DateTime shutdownTime = DateTime.Today.AddHours(17); 

            if (now >= shutdownTime && now < shutdownTime.AddMinutes(1))
            {
                Console.WriteLine("It's 5 PM! Shutting down the computer...");
                Process.Start("shutdown", "/s /t 0");
                break;
            }

            Thread.Sleep(60000); 
        }
    }
}
