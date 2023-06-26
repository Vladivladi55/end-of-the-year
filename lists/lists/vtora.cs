using System;
using System.Collections.Generic;

namespace vladi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();

            int n = int.Parse(Console.ReadLine());
            int input;
            for(int i = 0; i<n;i++)
            {
                input = int.Parse(Console.ReadLine());
                ints.Add(input);
            }
            for(int m = ints.Count-1; m>=0;m--)
            {
                Console.WriteLine(ints[m]);
            }

        }
    }
}
