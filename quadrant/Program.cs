using System;

namespace quadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool xN = x < 0;
            bool yN = y < 0;
            if(xN && yN)
            {
                Console.WriteLine("3");
            }
            else if (xN)
            {
                Console.WriteLine("2");
            }
            else if (yN)
            {
                Console.WriteLine("4");
            }
            else
            {
                Console.WriteLine("1");
            }
            
        }
    }
}
