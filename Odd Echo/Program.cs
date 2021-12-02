using System;
using System.Collections.Generic;

namespace Odd_Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstinput = Console.ReadLine();
            int repeats = Int32.Parse(firstinput);
            List<string> output = new List<string>();
            for(int i = 0; i < repeats; i++)
            {
                string nwInput = Console.ReadLine();
                if (i % 2 == 0)
                {
                    output.Add(nwInput);
                }
            }
            for(int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
