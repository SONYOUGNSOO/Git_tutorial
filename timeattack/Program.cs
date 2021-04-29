using System;
using System.Diagnostics;
using System.Threading;
namespace timeattack
{
    class Program
    {
        static void longtime()
        {
            Thread.Sleep(3000);
        }
        static void Main(string[] args)
        {

            Stopwatch timer = new Stopwatch();
            timer.Start();
            longtime();
            timer.Stop();

            Console.WriteLine($"{timer.Elapsed.TotalMilliseconds}");
            Console.WriteLine($"{timer.Elapsed.Seconds}");
        }
    }
}
