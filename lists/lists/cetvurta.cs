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
            for(int m = 0; m<ints.Count;m++)
                if (ints[m] < 0)
                    ints.RemoveAt(m);

            for (int m = 0; m < ints.Count; m++)
                Console.Write(ints[m] + " ");
        }
    }
}
