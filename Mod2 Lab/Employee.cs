using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab
{
    class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        private static int employeeCount = 1;

        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public double EmployeeBaseSalary { get => employeeBaseSalary; set => employeeBaseSalary = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }

        public Employee(string name, double baseSalary)
        {
            this.EmployeeName = name;
            this.EmployeeBaseSalary = baseSalary;
            this.EmployeeId = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.EmployeeBaseSalary;
        }

        public string getName()
        {
            return this.EmployeeName;
        }

        public int getEmployeeId()
        {
            return this.EmployeeId;
        }

        public string toString()
        {
            return this.EmployeeId + " " + this.EmployeeName;
        }

        public virtual string employeeStatus()
        {
            return toString() + " is in the company's system";
        }
    }
}
