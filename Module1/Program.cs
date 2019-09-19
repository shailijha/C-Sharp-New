using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            //drinksmachine mymachine = new drinksmachine("hyderabad, india", "dm1000", "brand");

            //console.writeline("mymachine location: {0}, mymachine make: {1}, mymachine model: {2}", mymachine.location, mymachine.make, mymachine.model);
            //mymachine.makecappuccino();
            Console.WriteLine(Math.Pow(2, 5));

            //Creating anonymous class
            var anon = new { Name = "Shaili", Age = 27 };

            Console.WriteLine($"{anon.Name} {anon.Age}");
        }
    }
}
