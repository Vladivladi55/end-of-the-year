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
                int index = email.IndexOf("@");
                //Console.WriteLine(email.Substring(0, index));
                Console.WriteLine(email.Substring(index+1));
            }
        }
    }
}
