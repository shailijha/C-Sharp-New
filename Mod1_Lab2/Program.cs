using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Color = "white";
            car1.Year = 2010;
            car1.Mileage = 11000;

            var car2 = new Car("Red", 2008);

            Console.WriteLine($"There are {Car.CountCars()} cars on inventory right now");
        }
    }
}
