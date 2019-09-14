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
        }
    }
}
