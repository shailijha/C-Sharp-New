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
            DrinksMachine myMachine = new DrinksMachine("Hyderabad, India", "DM1000", "Brand");
            
            Console.WriteLine("myMachine location: {0}, myMachine make: {1}, myMachine model: {2}", myMachine.Location, myMachine.Make, myMachine.Model);
            myMachine.MakeCappuccino();
        }
    }
}
