using System;
using System.Collections.Generic;


namespace MyApp
{
    internal class Program
    {   
       int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 100000; i <= 999999; i++)
            {
                int tempResult = 1;
                int currNum = i;
                while (currNum > 0)
                {
                    int digit = currNum % 10;
                    tempResult *= digit;
                    currNum = currNum / 10;
                }
                if(tempResult == magicNumber)
                {
                    Console.Write($"{i} ");
                }
    }
}
