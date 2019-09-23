using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab
{
    class BusinessEmployee: Employee
    {
        public int budget = 1000;

        public BusinessEmployee(string name) : base(name,50000)
        {

        }

        public override string employeeStatus()
        {
            return ($"{this.toString()} with a budget of {this.budget}");
            //return base.employeeStatus();
        }
    }
}
