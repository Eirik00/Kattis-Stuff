using System;

namespace Rating_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jar = (Console.ReadLine()).Split(" ");
            int judges = Int32.Parse(jar[0]);
            int ratings = Int32.Parse(jar[1]);
            int totRat = 0;
            float maxRate = 0;
            float minRate = 0;
            int ratingLeft = judges - ratings;

            for (int i = 0; i < ratings; i++)
            {
                totRat = totRat + Int32.Parse(Console.ReadLine());
            }
            for(int i = 0; i < ratingLeft; i++)
            {
                maxRate = maxRate + 3;
                minRate = minRate - 3;
            }
            maxRate = (maxRate + totRat)/judges;
            minRate = (minRate + totRat)/judges;
            Console.WriteLine(minRate + " " + maxRate);
        }
    }
}
