using Classes.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person shaili = new Person();
            shaili.firstName = "Shaili";
            shaili.lastName = "Jha";
            shaili.Introduce();

            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(90, 80));

            var numbers = new int[3];
            numbers[0] = 90;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Shaili", "Tatshini", "Naveen" };
        }
    }
}
