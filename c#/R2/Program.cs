using System;

namespace R2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int R1 = int.Parse(input.Split(" ")[0]);
            int S = int.Parse(input.Split(" ")[1]);
            Console.WriteLine((S * 2) - R1);
        }
    }
}
