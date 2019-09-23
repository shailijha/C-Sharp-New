using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Person
    {
        public string name;

        public void Introduce(string name)
        {
            Console.WriteLine($"Hi there, {name}! I am {this.name}");
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            var p1 = new Person();

            var p3 = Person.Parse("Jha");

            p.name = "Shaili";
            p.Introduce("Mosh");

            p3.Introduce("Mosh");
        }
    }
}
