﻿using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = (Console.ReadLine()).Split(" ");
            int a = Int32.Parse(input[0]);
            int b = Int32.Parse(input[1]);
            Console.WriteLine((a * b)/2f);
        }
    }
}
