using System;
using System.Collections.Generic;
using System.Linq;

namespace Heimavinna
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = 0;

            List<string> problemsInput = new List<string>();
            problemsInput = Console.ReadLine().Split(";").ToList();

            for(int i = 0; i < problemsInput.Count(); i++)
            {
                try
                {
                    int.Parse(problemsInput[i]);
                    numb += 1;
                }
                catch
                {
                    string[] split = problemsInput[i].Split("-");
                    numb += 1+(int.Parse(split[1]) - int.Parse(split[0]));
                }
            }
            Console.WriteLine(numb);
        }
    }
}
