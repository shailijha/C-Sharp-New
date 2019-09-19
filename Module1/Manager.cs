using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Manager: Employee
    {
        private string department;

        public string Department { get => department; set => department = value; }

        public override void Login()
        {
            base.Login();
            Console.WriteLine("Manager Login");
        }

        public override void Hire()
        {
            Console.WriteLine("Hire people");
            //throw new NotImplementedException();
        }
    }
}
