// Juozas Sadauskas
// Salary Calculator app
using System;
using System.Collections.Generic;

class Employee
{
    // Property for the employee's name
    public string Name { get; set; }
    // Property for the employee's hourly rate
    public double HourlyRate { get; set; }
    // Property for the employee's hours worked
    public double HoursWorked { get; set; }

    // Constructor for the Employee class
    public Employee(string name, double hourlyRate)
    {
        Name = name;
        HourlyRate = 0;
        HoursWorked = 0;
    }

    // Method for calculating the employee's gross pay
    public double CalculateGrossPay()
    {
        double grossPay = 0;

        if (HoursWorked <= 40)
        {
            grossPay = HoursWorked * HourlyRate;
        }
        else
        {
            int regularHours = 40;
            double overtimeHours = HoursWorked - regularHours;
            grossPay = (regularHours * HourlyRate) + (overtimeHours * HourlyRate * 1.5);
        }

        return grossPay;
    }

    // Method for calculating the employee's net pay
    public double CalculateNetPay()
    {
        double grossPay = CalculateGrossPay();
        double taxPay = grossPay - (grossPay * 0.125);
        return taxPay;
    }

    // Method for displaying the employee's pay information
    public void DisplayPay()
    {
        Console.WriteLine($"\nEmployee: {Name}");
        Console.WriteLine($"Hourly Rate: €{HourlyRate}");
        Console.WriteLine($"Hours Worked: {HoursWorked}");
        Console.WriteLine($"Gross Pay: €{Math.Round(CalculateGrossPay(), 2)}");
        Console.WriteLine($"Tax Rate: 12.5%");
        Console.WriteLine($"Total Pay: €{Math.Round(CalculateNetPay(), 2)}");
        Console.WriteLine(".................................\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\t\t\t.................................");
        Console.WriteLine("\t\t\tWelcome to Salary Calculator app.");
        Console.WriteLine("\t\t\t.................................\n");

        // List of employees
        List<Employee> employees = new List<Employee>

        {
            new Employee("Nendartalian", 0),
            new Employee("Itty Bitty", 0),
            new Employee("Chewbacca", 0)
        };


        for (int i = 0; i < employees.Count; i++)
        {
            // Inputs from user for worked hours
            Console.Write("Enter hourly rate for {0}: €", employees[i].Name);
            employees[i].HourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter hours worked for {0}: ", employees[i].Name);
            employees[i].HoursWorked = Convert.ToDouble(Console.ReadLine());

            employees[i].DisplayPay();
        }
        Console.WriteLine("Thank you for using Salary Calculator!!!");

    }
}