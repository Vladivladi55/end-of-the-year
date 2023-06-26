using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyApp
{
    class Car 
    {
        public string model;
        public double tank;
        public double consumption;

         public void Drive(int distance)
        {
            if (distance * consumption <= tank)
            {
                tank -= distance * consumption;
                if(tank < 0)
                {
                    tank = 0;
                }
                Console.WriteLine($"{this.model} {this.tank} {distance}");
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive.");
            }
    }


    internal class Program
    {   
        int CarsAmount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for(int i = 1; i <= CarsAmount; i++)
            {
                string[] info = Console.ReadLine().Split().ToArray();

                Car CurrCar = new Car(info[0], double.Parse(info[1]), double.Parse(info[2]));
            }
            string[] command = Console.ReadLine().Split().ToArray();     
    }
}
