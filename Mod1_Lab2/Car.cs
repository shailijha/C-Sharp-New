using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    public class Car
    {
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car(int year, float mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        public string Color { get; set; }
        public int Year { get; set; }
        public float Mileage { get; set; }

        private static int instances = 0;

        public Car()
        {
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }
    }
}
