using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Color = "white";
            car1.Year = 2010;
            car1.Mileage = 11000;

            Console.WriteLine("Car 1's properties: {0} car built in {1} with {2} miles on it", car1.Color, car1.Year, car1.Mileage);
            Console.WriteLine($"This car is painted {car1.Color}, was built in {car1.Year}, and has {car1.Mileage} miles on it");
        }
    }
}
