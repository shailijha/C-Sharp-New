using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number;
            //var result = int.TryParse("abc", out number);
            //if(result)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("Not converted");

            var person = new Person();
            person.SetBirthDate(new DateTime(1992, 9, 11));
            Console.WriteLine(person.GetBirthDate());
        }

        static void UseParams()
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(2, -3, 9, -100));
            Console.WriteLine(calc.Add(2, -3, 9));
            Console.WriteLine(calc.Add(new int[] { 2, -3, 9, -100 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"The point is at ({point.x}, {point.y})");

                point.Move(30, 50);
                Console.WriteLine($"The point is at ({point.x}, {point.y})");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
