using System;

namespace MyApp
{
    internal class Program
    {   
        static void Main(string[] args)
        {
           while(true) 
           {
            string input = Console.ReadLine();
            if(input == "rectangle")
            {
                Console.Write("enter a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("enter b: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("S = " + a*b);
            }
            else if(input == "square")
            {
                Console.Write("Enter a: ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("S = " + a*a);
            }
             else if (figure == "circle")
            {
                Console.Write("Enter : ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine(Math.PI*r*r);
            }
           }
        }
    }
}
