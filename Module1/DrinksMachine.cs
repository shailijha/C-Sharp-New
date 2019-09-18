using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class DrinksMachine
    {
        public DrinksMachine(string location, string make, string model)
        {
            this.Location = location;
            this.Make = make;
            this.Model = model;
        }

        private string _location;
        private string _make;
        private string _model;

        public string Location { get => _location; set => _location = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }

        public void MakeCappuccino()
        {
            //Do something
            Console.WriteLine("Cappuccino has been made");
        }

        public void MakeExpresso()
        {
            //Do something

        }
    }
}
