using System;

namespace Cold_puter_Science
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int coldWeather = 0;
            string[] input = Console.ReadLine().Split(" ");
            foreach (string x in input)
                if(int.Parse(x) < 0)
                {
                    coldWeather++;
                }
            Console.WriteLine(coldWeather);
        }
    }
}
