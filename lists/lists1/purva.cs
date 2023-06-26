using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            string input = Console.ReadLine();
            int sum = 0;
            while(input != "stop")
            {
                ints.Add(int.Parse(input));
                input = Console.ReadLine();
            }
            int n = ints.Count();
            if(n%2==0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    int first = ints[i];
                    int last = ints[ - 1 - i];

                    sum += (first + i) + (last - i);
                }
            }
            else 
            {
                for (int i = 0; i < n / 2; i++)
                {
                    int first = ints[i];
                    int last = ints[n - 1 - i];

                    sum += (first + i) + (last - i);
                }

                sum += ints[n / 2];
            }
        }
    }
}
