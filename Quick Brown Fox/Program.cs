using System;
using System.Collections.Generic;
using System.Linq;

namespace Quick_Brown_Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            for(int i = 0; i < repeats; i++)
            {
                List<char> alpha = "abcdefghijklmnopqrstuvwxyz".ToList();
                string x = new String(Console.ReadLine().ToLower().Where(Char.IsLetter).ToArray());
                char[] xy = x.ToCharArray();
                string missing = "";
                xy = xy.Distinct().ToArray();
                List<char> input = x.ToList();
                foreach(char h in input)
                {
                    alpha.Remove(h);
                }
                if (alpha.Count > 0)
                {
                    foreach (char xyz in alpha)
                        missing += xyz.ToString();
                    Console.WriteLine("missing " + missing);
                }
                else
                {
                    Console.WriteLine("pangram");
                }
            }
        }
    }
}
