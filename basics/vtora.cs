using System;
using System.Collections.Generic;


namespace MyApp
{
    internal class Program
    {   
       double Mtomm = 1000;
            double Mtocm = 100;
            double Mtomi = 0.000621371192;
            double Mtoin = 39.3700787;
            double Mtokm = 0.001;
            double Mtoft = 3.2808399;
            double Mtoyd = 1.0936133;

            double input = double.Parse(Console.ReadLine());
            string StartType = Console.ReadLine();
            string EndType = Console.ReadLine();

            //Convert The Input to Meters
            if(StartType == "mm")
            {
                input = input / Mtomm;
            }
            else if (StartType == "cm")
            {
                input = input / Mtocm;
            }
            else if (StartType == "mi")
            {
                input = input / Mtomi;
            }
            else if (StartType == "in")
            {
                input = input / Mtoin;
            }
            else if (StartType == "km")
            {
                input = input / Mtokm;
            }
            else if (StartType == "ft")
            {
                input = input / Mtoft;
            }
            else
            {
                input = input / Mtoyd;
            }

            //Convert into wanted type
            if (EndType == "mm")
            {
                input = input * Mtomm;
            }
            else if (EndType == "cm")
            {
                input = input * Mtocm;
            }
            else if (EndType == "mi")
            {
                input = input * Mtomi;
            }
            else if (EndType == "in")
            {
                input = input * Mtoin;
            }
            else if (EndType == "km")
            {
                input = input * Mtokm;
            }
            else if (EndType == "ft")
            {
                input = input * Mtoft;
            }
            else
            {
                input = input * Mtoyd;
            }
            Console.WriteLine(input);
    }
}
