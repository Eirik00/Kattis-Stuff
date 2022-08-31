using System;

namespace N_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            string[] integers = Console.ReadLine().Split(" ");
            int sum = 0;
            for(int i = 0; i < repeats; i++)
            {
                sum += int.Parse(integers[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
