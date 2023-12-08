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
            Console.WriteLine("\n\t\t(--------------------Create Account---------------------)");
        }

        static public void ShowLogin()
        {
            Console.WriteLine("\n\t\t(----------------Login--------------------)");
        }

        static public void AcceptdLogin()
        {
            Console.WriteLine("\n\t\t(--------------------Acceptd Login---------------------)");

        }

        static public void HoursAndDate()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine($"\n\t\t(----------------{time}---------------------");
        }

        static public void ChooseUser()
        {
            Console.WriteLine("\n \t(1) Calculator of average \t(2) List of employees \t(3) Exit of progam");
        }

        static public void CalculatorAverage()
        {
            Console.WriteLine("\n\t\t(--------------------Calculator Average---------------------)");
        }

        static public void List()
        {
            Console.WriteLine("\n\t\t(--------------------Register Employees---------------------)");

        }

        static public void ChooseEmployeeFunc()
        {
            Console.WriteLine("\n\t\t(-----------------------------Functional of List--------------------------)");
            Console.WriteLine("\n(1) Addtional Employee \t(2) Remove Employee \t(3) Increase Salary\t(4) Decrease Salary \t(5) Show list \t(6) Exit for home");
        }

        static public void AddiotionalEmp()
        {
            Console.WriteLine("\n\t\t(--------------------Additional Employees---------------------)");
        }

        static public void RemoveEmp()
        {
            Console.WriteLine("\n\t\t(--------------------Remove Employees---------------------)");
        }

        static public void IncreaseSalary()
        {
            Console.WriteLine("\n\t\t(--------------------Increase Salary---------------------)");
        }

        static public void DecreaseSalary()
        {
            Console.WriteLine("\n\t\t(--------------------Decrease Salary---------------------)");
        }
    }
}
