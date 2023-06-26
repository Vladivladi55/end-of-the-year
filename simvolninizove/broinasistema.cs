using System;

namespace MyApp
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            int n = 0; 
            string number = Console.ReadLine();
            for(int i = 0; i<number.Length; i++)
            {
                n =+ i*number[i]^i;
            }

        }
    }
}
