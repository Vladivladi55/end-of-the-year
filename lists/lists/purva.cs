using System;
using System.Collections.Generic;

namespace vladi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            string input;
            while(input!="stop")
            {
                ints.Add(int.Parse(input));
                intput = Console.ReadLine();
            }
            int count = 0;
            for (int i = 0; i < ints.Count; i++)
               count=+ ints[i];

            Console.WriteLine(count + " " + count / ints.Count);
            ints.Sort();
        }
    }
}
