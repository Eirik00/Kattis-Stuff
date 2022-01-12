using System;

namespace jumbojavelin
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum-num+1);
        }
    }
}
