using System;

namespace DataPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            int dataPlan = Int32.Parse(Console.ReadLine());
            int weeks = Int32.Parse(Console.ReadLine());
            int leftover = 0;

            for(int i = 0; i < weeks; i++)
            {
                leftover = leftover + dataPlan;
                int usedMonth = Int32.Parse(Console.ReadLine());
                leftover = leftover - usedMonth;
            }
            Console.WriteLine(leftover + dataPlan);
        }
    }
}
