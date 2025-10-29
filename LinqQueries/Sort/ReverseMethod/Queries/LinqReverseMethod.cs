using LINQ.Models.Employee;
using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.Sort.ReverseMethod.Queries
{
    internal class LinqReverseMethod
    {
        internal static void ExecuteReverse()
        {
            Console.WriteLine("\n--------------------- Reverse ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Reverse Method \n\n");

            var employees = GenerateData.GetEmployees();

            Console.WriteLine("Original sequence of employees: \n");

            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee Name: {employee.FirstName} \nEmployee Annual Salary: {employee.AnnualSalary} \n");
            }

            // Using LINQ Reverse method to reverse the order of elements
            var reversedEmployees = employees.Select(employee => new { FN = employee.FirstName, Salary = employee.AnnualSalary }).Reverse();

            Console.WriteLine("\nReversed Numbers: \n");

            foreach (var reversedEmployee in reversedEmployees)
            {
                Console.WriteLine($"Employee Name: {reversedEmployee.FN} \nEmployee Annual Salary: {reversedEmployee.Salary} \n");
            }
        }
    }
}
