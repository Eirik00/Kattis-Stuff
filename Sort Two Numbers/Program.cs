using System;

namespace Sort_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] twoNums = (Console.ReadLine()).Split(" ");
            int a = Int32.Parse(twoNums[0]);
            int b = Int32.Parse(twoNums[1]);
            if (a > b) { Console.WriteLine(b + " " + a); } else { Console.WriteLine(a + " " + b); }
        }
    }
}
