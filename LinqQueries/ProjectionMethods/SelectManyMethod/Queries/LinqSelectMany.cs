using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.ProjectionMethods.SelectManyMethod.Queries
{
    internal class LinqSelectMany
    {
        internal static void ExecuteLinqSelectMany()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------- Select Many ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Link Select Many \n\n");

            var employees = GenerateData.GetEmployees();

            var employeesWithSameAnnualSalary = employees.GroupBy(employee => employee.FirstName).Where(employee => employee.Count() > 1).SelectMany(employee => employee).ToList();

            if (employeesWithSameAnnualSalary.Any())
            {
                foreach (var employee in employeesWithSameAnnualSalary)
                {
                    Console.WriteLine($"Employee Name: {employee.FirstName} \nEmployee Annual Salary: {employee.AnnualSalary}\n");
                }
            }
            else
            {
                Console.WriteLine("No employees found with the same annual salary.");
            }
        }
    }
}
