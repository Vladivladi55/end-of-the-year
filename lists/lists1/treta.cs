using System;
using System.Collections.Generic;



namespace MyApp
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            List<string> grocery = new List<string>();
            int n = int.Parse(Console.ReadLine())
            
            for(int i = 0; i<n; i++)
                grocery.Add(Console.ReadLine());

            grocery.Sort();
        }
    }
}
