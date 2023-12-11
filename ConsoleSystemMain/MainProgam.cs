using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Text;
using System.Globalization;


namespace SimpleProject
{

    class SystemMain
    {
        
        static Login LoginManager = new Login();
        static Login CurrentUser = new Login();

        static void Main(string[] args)
        {
            Interface.HoursAndDate();
            Interface.ShowCreateAccount();
            MainLogin();
        }

        static void MainLogin()
        {

            Console.WriteLine("Create your username: ");
            CurrentUser.Username = Console.ReadLine();

            Console.WriteLine("Create your password: ");
            CurrentUser.Password = Console.ReadLine();

            if (CurrentUser.Password != null && CurrentUser.Username != null)
            {
                while (LoginManager.LoopWhile < 3)
                {

                    Interface.ShowLogin();

                    Console.WriteLine("Enter username: ");
                    CurrentUser.KeyUsername = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    CurrentUser.KeyPassword = Console.ReadLine();

                    LoginManager.IncreaseLoopWhile();

                    if (CurrentUser.VerifyLogin())
                    {
                        Interface.AcceptdLogin();
                        LoginManager.ResetLoopWhile();

                        while (LoginManager.LoopWhile < 3)
                        {
                            Interface.Home();
                            Interface.ChooseUser();
                            LoginManager.Choice = Math.Abs(int.Parse(Console.ReadLine()));
                            if (LoginManager.Choice > 0 && LoginManager.Choice < 4)
                            {
                                Functionalities();
                            }
                            else
                            {
                                LoginManager.IncreaseLoopWhile();
                                Console.WriteLine("Choice must be from 1 to 3");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect username or password!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Username or password create is incorrect");
            }

        }
        static void Functionalities()
        {
            if (LoginManager.Choice == 1)
            {
                LoginManager.ResetLoopWhile();
                Interface.CalculatorAverage();
                while (LoginManager.ExitOfAverage == 's' || LoginManager.ExitOfAverage == 'S')
                {
                    CalculatorAverage();
                }

            }

            else if (LoginManager.Choice == 2)
            {
                Interface.List();
                EmpList();

                if (LoginManager.VerifyGoHome == 1)
                {
                    //Vai para a interface original caso o usuario digite 6 nas opções detro da função emplist
                    LoginManager.ResetLoopWhile();
                }

            }
            else if (LoginManager.Choice == 3)
            {
                Environment.Exit(0);
            }
        }

        static void CalculatorAverage()
        {
            Average cal = new Average();

            Console.WriteLine("\nThe average of how many number you want yo see? ");
            cal.Count = Math.Abs(int.Parse(Console.ReadLine()));

            for (int i = 0; i < cal.Count; i++)
            {
                Console.Write($"Enter value({i + 1}): ");
                cal.Total += Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine();
            }
            Console.WriteLine(cal);
            Console.WriteLine("You he can realized other calculate of average? (S/N)");
            LoginManager.ExitOfAverage = char.Parse(Console.ReadLine());
        }

        static void EmpList()
        {

            List<Employee> list = new List<Employee>();
            Employee functionEmp = new Employee();

            Console.Write("\nHow many employeers he can register? ");
            functionEmp.ForEmp = Math.Abs(int.Parse(Console.ReadLine()));

            for (int i = 0; i < functionEmp.ForEmp; i++)
            {
                Console.WriteLine($"\nEmployee ({i + 1}): ");
                Console.Write("Name: ");
                functionEmp.TempName = Console.ReadLine();
                Console.Write("Id: ");
                functionEmp.TempId = Math.Abs(int.Parse(Console.ReadLine()));
                Console.Write("Salary: ");
                functionEmp.TempSalary = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                list.Add(new Employee(functionEmp.TempName, functionEmp.TempId, functionEmp.TempSalary));
            }
            while (LoginManager.LoopWhile < 3)
            {
                Interface.ChooseEmployeeFunc();
                functionEmp.ChoiseEmp = Math.Abs(int.Parse(Console.ReadLine()));
                if (functionEmp.ChoiseEmp > 0 && functionEmp.ChoiseEmp < 7)
                {

                    if (functionEmp.ChoiseEmp == 1)
                    {
                        Interface.AddiotionalEmp();

                        Console.WriteLine("Name: ");
                        functionEmp.TempName = Console.ReadLine();
                        Console.WriteLine("Id: ");
                        functionEmp.TempId = Math.Abs(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Salary: ");

                        functionEmp.TempSalary = Math.Abs(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        list.Insert(0, new Employee(functionEmp.TempName, functionEmp.TempId, functionEmp.TempSalary));

                        foreach (Employee item in list)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else if (functionEmp.ChoiseEmp == 2)
                    {
                        Interface.RemoveEmp();
                        Console.WriteLine("Enter ID your wants to remove: ");
                        functionEmp.TempId = Math.Abs(int.Parse(Console.ReadLine()));

                        Employee empRemo = list.Find(x => x.EmployeeId == functionEmp.TempId);

                        if (empRemo != null)
                        {
                            list.Remove(empRemo);
                            if (LoginManager.VerifyGoHome == 1)
                            {
                                LoginManager.ResetLoopWhile();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not found this id");
                        }

                        foreach (Employee item in list)
                        {
                            Console.WriteLine(item);
                        }
                    }

                    else if (functionEmp.ChoiseEmp == 3)
                    {
                        Interface.IncreaseSalary();
                        Console.WriteLine("Enter id who will of increase salary");
                        functionEmp.TempId = Math.Abs(int.Parse(Console.ReadLine()));

                        Employee empIncrease = list.Find(x => x.EmployeeId == functionEmp.TempId);

                        if (empIncrease != null)
                        {
                            Console.WriteLine("Enter the percentage of salary increase: ");
                            empIncrease.Increase = Math.Abs(int.Parse(Console.ReadLine()));
                            empIncrease.CalculateIncrease();

                            foreach (Employee item in list)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Id not exist");
                        }
                    }

                    else if (functionEmp.ChoiseEmp == 4)
                    {
                        Interface.DecreaseSalary();
                        Console.WriteLine("Enter id who will of salary decrease: ");
                        functionEmp.TempId = Math.Abs(int.Parse(Console.ReadLine()));

                        Employee empDecrease = list.Find(x => x.EmployeeId == functionEmp.TempId);

                        if (empDecrease != null)
                        {
                            Console.WriteLine("Enter the percentage of salary decrease: ");
                            empDecrease.Decrease = Math.Abs(int.Parse(Console.ReadLine()));
                            empDecrease.CalculateDecrease();

                            foreach (Employee item in list)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Id not exist");
                        }
                    }
                    else if (functionEmp.ChoiseEmp == 5)
                    {
                        foreach (Employee item in list)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else if (functionEmp.ChoiseEmp == 6)
                    {
                        LoginManager.IncreaseOverLoopWhile();
                        LoginManager.IncreaseGoHome();
                    }

                }
                else
                {
                    LoginManager.IncreaseLoopWhile();
                    Console.Write("Choice must be from 1 to 5");
                }
            }
        }
    }
}