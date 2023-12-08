using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.Design.Serialization;
using System.Linq.Expressions;

namespace SimpleProject
{
    class Employee
    {

        public string EmployeeName { get; private set; }
        public int Increase { get; set; }
        public int Decrease { get; set; }
        public int EmployeeId { get; private set; }
        public double RealSalary { get; private set; }
        public string TempName { get; set; }
        public int TempId { get; set; }
        public double TempSalary { get; set; }
        public int ForEmp { get; set; }
        public int ChoiseEmp { get; set; }


        public Employee(string name, int id, double salary)
        {
            EmployeeName = name;
            EmployeeId = id;
            RealSalary = salary;
        }

        public Employee()
        {
        }

        public void CalculateIncrease()
        {
            RealSalary += RealSalary * ((double)Increase / 100);
        }

        public void CalculateDecrease()
        {
            RealSalary -= RealSalary * ((double)Decrease / 100);
        }
        public override string ToString()
        {
            return "\n\tId: "
                + EmployeeId
                + ", "
                + EmployeeName
                + ", "
                + " Salary: "
                + RealSalary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}