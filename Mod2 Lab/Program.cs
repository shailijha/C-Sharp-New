using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new TechnicalEmployee("Shaili");
            var emp2 = new TechnicalEmployee("XYZ");
            var emp3 = new BusinessEmployee("ABC");

            Console.WriteLine($"{emp1.employeeStatus()} ... {emp2.employeeStatus()} ... {emp3.employeeStatus()}");
        }
    }
}
