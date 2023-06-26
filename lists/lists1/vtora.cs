using System;
using System.Collections.Generic;



namespace MyApp
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            List<int> one = new List<int>();
            string input = Console.ReadLine();
            while(input != "stop")
            {
                one.Add(int.Parse(input));
                input = Console.ReadLine();
            }
            int n1 = one.Count();

            List<int> two = new List<int>();
            input = Console.ReadLine();
            int sum = 0;
            while(input != "stop")
            {
                two.Add(int.Parse(input));
                input = Console.ReadLine();
            }
            int n2 = two.Count();

            List<int> result = new List<int>();

            if(n1==n2)
            {
                for(int i = 0; i<n1;i++)
                {
                    result.Add(one[i]);
                    result.Add(two[i]);
                }
            }
            else if(n1<n2)
            {
                for(int i = 0; i<n1;i++)
                {
                    result.Add(one[i]);
                    result.Add(two[i]);
                    
                }
                for(int p = n1; p<n2;p++)
                    result.Add(two[p])
            }
            else
            {
                for(int i = 0; i<n2;i++)
                {
                    result.Add(one[i]);
                    result.Add(two[i]);
                }
                for(int p = n2; p<n1;p++)
                    result.Add(one[p])
            }
        }
    }
}
