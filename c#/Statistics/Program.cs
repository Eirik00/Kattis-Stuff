using System;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseNum = 0;
            int currNum, maxNum, minNum;
            string line;
            string output = "";
            int i;
            while ((line = Console.ReadLine()) != null){
                if(line == "") { break; }
                caseNum++;
                string[] x = line.Split(" ");
                maxNum = int.Parse(x[1]);
                minNum = int.Parse(x[1]);
                for(i = 1; i < int.Parse(x[0])+1; i++)
                {
                    currNum = int.Parse(x[i]);
                    if (currNum > maxNum)
                    {
                        maxNum = currNum;
                    }
                    else if(currNum < minNum)
                    {
                        minNum = currNum;
                    }
                }
                output += "Case " + caseNum + ": " + minNum + " " + maxNum + " " + (maxNum - minNum)+"\n";
            }
            Console.WriteLine(output);
        }
    }
}
