using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject
{
    class Interface
    {
        static public void ShowCreateAccount()
        {
            Console.WriteLine("\n\t(=== Create Account ===)\n");
        }

        static public void ShowLogin()
        {
            Console.WriteLine("\n\t(=== Login ===)\n");
        }

        static public void AcceptdLogin()
        {
            Console.WriteLine("\n\t(=== Acceptd Login ===)\n");

        }

        static public void Home()
        {
            Console.WriteLine("\n\t(=== Home ===)\n");

        }

        static public void HoursAndDate()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine($"\n\t(==={time}===)");
        }

        static public void ChooseUser()
        {
            Console.WriteLine("\n1. Calculator of average \n2. List of employees \n3. Exit of progam \nEnter (1/2/3): \n");
            
        }

        static public void CalculatorAverage()
        {
            Console.WriteLine("\n\t(=== Calculator Average ===) \n");
        }

        static public void List()
        {
            Console.WriteLine("\n\t(=== Register Employees ===) \n");
        }

        static public void ChooseEmployeeFunc()
        {
            Console.WriteLine("\n\t(=== Functional of List ===)");
            Console.WriteLine("\n(1) Addtional Employee \n(2) Remove Employee \n(3) Increase Salary\n(4) Decrease Salary \n(5) Show list \n(6) Exit for home \n");
            Console.WriteLine("Enter (1/2/3/4/5/6): ");
        }

        static public void AddiotionalEmp()
        {
            Console.WriteLine("\n\t(=== Additional Employees ===) \n");
        }

        static public void RemoveEmp()
        {
            Console.WriteLine("\n\t(=== Remove Employees ===) \n");
        }

        static public void IncreaseSalary()
        {
            Console.WriteLine("\n\t\t(=== Increase Salary ===) \n");
        }

        static public void DecreaseSalary()
        {
            Console.WriteLine("\n\t\t(=== Decrease Salary ===) \n");
        }
    }
}
