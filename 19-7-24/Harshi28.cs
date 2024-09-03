using System;
using System.Collections.Generic;

class Harshi28
{
    static void Main()
    {
        Console.WriteLine("Enter the number of employees:");
        if (!int.TryParse(Console.ReadLine(), out int numberOfEmployees) || numberOfEmployees <= 0)
        {
            Console.WriteLine("Invalid number of employees. Please restart the program and enter a valid number.");
            return;
        }

        List<Employee> employees = new List<Employee>();
        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine($"Enter name for employee {i + 1}:");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter salary for employee {i + 1}:");
            if (double.TryParse(Console.ReadLine(), out double salary))
            {
                employees.Add(new Employee { Name = name, Salary = salary });
            }
            else
            {
                Console.WriteLine("Invalid salary. Please restart the program and enter valid salary amounts.");
                return;
            }
        }

        double totalSalary = CalculateTotalSalary(employees);
        Console.WriteLine($"Total salary of all employees: {totalSalary}");
    }

    static double CalculateTotalSalary(List<Employee> employees)
    {
        double total = 0;
        foreach (var employee in employees)
        {
            total += employee.Salary;
        }
        return total;
    }
}

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
}