// Employee hierarchy test application.
// Grading ID: 
using System;
using static System.Console;

public class PayrollSystemTest
{
    public static void Main(string[] args)
    {
        // create derived class objects
        SalariedEmployee salariedEmployee1 =
           new SalariedEmployee("John", "Smith", "111-11-1111", 800.00); // Salaried
        HourlyEmployee hourlyEmployee1 =
           new HourlyEmployee("Karen", "Price", "222-22-2222", 46.75, 40); // Hourly
        SalariedEmployee salariedEmployee2 =
           new SalariedEmployee("Sue", "Jones", "333-33-3333", 1000.00); // Salaried
        HourlyEmployee hourlyEmployee2 =
           new HourlyEmployee("Bob", "Lewis", "444-44-4444", 45.25, 45); // Hourly
        CommissionEmployee commissionEmployee1 =
            new CommissionEmployee("Jay", "Johnson", "555-55-5555", 0.075);
        CommissionEmployee commissionEmployee2 =
            new CommissionEmployee("Jay", "Johnson", "555-55-5555", 0.075);
        // Create 2 CommissionEmployee objects as directed below *******************************
        // Jay Johnson, 555-55-5555, earns 7.5% (0.075) commission, on $35,000 in sales. Earnings of $2,625
        // Mary Mathis, 666-66-6666, earns 8.0% (0.08) commission, on $40,000 in sales. Earnings of $3,200

        // Add your 2 CommissionEmployee objects to array below *******************************
        // create Employee array
        Employee[] employees = { salariedEmployee1, hourlyEmployee1,
            salariedEmployee2, hourlyEmployee2, commissionEmployee1, commissionEmployee2 };

        WriteLine("Employees processed polymorphically:\n");

        // generically process each element in array employees
        foreach (Employee currentEmployee in employees)
        {
            WriteLine(currentEmployee); // invokes ToString implicitly
            WriteLine($"earned {currentEmployee.CalcEarnings():C}");
            WriteLine();
        } // end foreach
    } // end Main
} // end class PayrollSystemTest
