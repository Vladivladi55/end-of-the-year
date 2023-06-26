using System;

namespace MyApp
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            while(true) 
            {
                string email = Console.ReadLine();
                if(email.Contains("@"))
                    if(email.Contains("."))
                       Console.WriteLine("true");
                else 
                        Console.WriteLine("FALSE");

            }
        }
    }
}
