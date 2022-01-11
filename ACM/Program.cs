using System;
using System.Collections.Generic;

//Må heller lage rom hvor du setter den minste intervalet du kan siden et rom kan ikke ha 1 2 + 2 4 + 4 5 siden 1 2 og 4 5 ikke går

namespace ACM
{
    class Program
    {
        static void Main(string[] args)
        {

            int minions = int.Parse(Console.ReadLine());
            int rooms = minions;
            List<string> inputs = new List<string>();

            for (int i = 0; i < minions; i++)
            {
                string inputMinion = Console.ReadLine();
                int x1 = int.Parse(inputMinion.Split(" ")[0]);
                int y1 = int.Parse(inputMinion.Split(" ")[1]);
                bool remove = false;

                for (int x = 0; x < inputs.Count; x++)
                {
                    int x2 = int.Parse(inputs[x].Split(" ")[0]);
                    int y2 = int.Parse(inputs[x].Split(" ")[1]);
                    for (int j = x1; j<y1; j++)
                    {
                        if (j >= x2 && j <= y2)
                        {
                            rooms -= 1;
                            remove = true;
                            break;
                        }
                        else if (j <= x2 && y1 >= x2)
                        {
                            rooms -= 1;
                            remove = true;
                            break;
                        }
                    }
                }
                if (remove == false)
                {
                    inputs.Add(inputMinion);
                }

            }
            Console.WriteLine(rooms);
        }
    }
}
//please work :,)