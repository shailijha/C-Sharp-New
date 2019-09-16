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
            Console.WriteLine(sampleText);

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 4;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method);

            var sampleString = "RegularAirMail";
            var sample = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), sampleString);
            Console.WriteLine(sample);

            int hour = 10;
            if(hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if(hour >=12 && hour <= 16)
            {
                Console.WriteLine("It's afternoon");
            }
            else if (hour > 16 && hour < 19)
            {
                Console.WriteLine("It's evening");
            }
            else
            {
                Console.WriteLine("It's night");
            }

            var season = Season.Summer;

            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("It's Spring Season!");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer Season!");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's Autumn Season!");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter Season!");
                    break;
                default:
                    Console.WriteLine("Invalid Season");
                    break;
            }

            //for(var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //var name = "Shaili Jha";

            //for(var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach(var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //while(true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();

            //    if(String.IsNullOrWhiteSpace(input))
            //        break;
            //    else
            //        Console.WriteLine(input);
            //}

            var random = new Random();

            for(var i = 0; i < 10; i++)
            {
                Console.Write((char)('a' + random.Next(0,26)));
            }
            Console.WriteLine();

        }
    }
}
