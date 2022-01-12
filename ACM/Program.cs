using System;
using System.Collections.Generic;
using System.Linq;

namespace ACM
{

    class Program
    {
        class Minion
        {
            public int MinPrefTemp { get; set; }
            public int MaxPrefTemp { get; set; }
        }
        static void Main(string[] args)
        {

            int minions = int.Parse(Console.ReadLine());
            int rooms = 1;
            List<Minion> minionTemps = new List<Minion>();

            for (int i = 0; i < minions; i++)
            {
                string input = Console.ReadLine();
                Minion newMinion = new Minion();
                newMinion.MinPrefTemp = int.Parse(input.Split(" ")[0]);
                newMinion.MaxPrefTemp = int.Parse(input.Split(" ")[1]);
                minionTemps.Add(newMinion);
            }
            minionTemps.Sort((x,y) => x.MaxPrefTemp.CompareTo(y.MaxPrefTemp));

            int threshold = minionTemps[0].MaxPrefTemp;


            for (int i = 1; i< minionTemps.Count(); i++)
            {
                if(minionTemps[i].MinPrefTemp > threshold)
                {
                    threshold = minionTemps[i].MaxPrefTemp;
                    rooms++;
                }
            }
            Console.WriteLine(rooms);
        }
    }
}
//please work :,)