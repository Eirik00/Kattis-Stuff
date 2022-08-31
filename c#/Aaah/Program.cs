using System;

namespace Aaah
{
    class Program
    {
        static void Main(string[] args)
        {
            int jon = ((Console.ReadLine()).Split("h"))[0].Length;
            int doctor = ((Console.ReadLine()).Split("h"))[0].Length;

            if(jon >= doctor) {
                Console.WriteLine("go");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
