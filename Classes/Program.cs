using Classes.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Person shaili = new Person();
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

            var firstName = "Shaili";
            var lastName = "Jha";

            var name = string.Format("My name is {0} {1}", firstName, lastName);

            Console.WriteLine(name);

            var friendsNames = string.Format("My friends names are {0}", string.Join(",",names));

            Console.WriteLine(friendsNames);

            var sampleText = @"Hi Shaili
Look into the following path
c:\f1\f2
c:\f3\f4";
            Console.WriteLine(sampleText);*/

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 4;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method);

            var sampleString = "RegularAirMail";
            var sample = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), sampleString);
            Console.WriteLine(sample);
        }
    }
}
