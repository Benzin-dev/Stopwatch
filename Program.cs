using System;


namespace Stopwatch
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var timer = new TimeCount();

            while (true)
            {
                Console.WriteLine(" 's' to start\n 'f' to finish\n 'q' to quit");
                var input = Console.ReadLine();

                if (input=="s")
                {
                    timer.Start();
                    Console.WriteLine("Timer has started");
                }
                else if (input=="f")
                {
                    var result = timer.Stop(DateTime.Now);
                    Console.WriteLine("Time spend: " + result);
                    continue;
                }
                else if (input=="q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Only 's', 'f' and 'q' are available");
                }
            }

            
        }
    }
}
