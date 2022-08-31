using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStops = Int32.Parse(Console.ReadLine());
            int prevLiners = 0;
            int time = 0;
            for(int i = 0; i < numberOfStops; i++)
            {
                int readLiners = Int32.Parse(Console.ReadLine());
                if (numberOfStops % 2 == 0)
                {
                    if (i % 2 != 0)
                    {
                        time = time +(readLiners-prevLiners);
                    }
                }
                prevLiners = readLiners;
            }
            if (numberOfStops % 2 == 0){
                Console.WriteLine(time);
            }
            else
            {
                Console.WriteLine("still running");
            }
        }
    }
}
