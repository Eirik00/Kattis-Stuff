using System;

namespace _0_1_Squences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string newString = "";
            foreach (char h in input)
                if(h.ToString() == "?")
                    newString += h;
            Console.WriteLine(1000000007 % Math.Pow(2,newString.Length));
        }
    }
}
