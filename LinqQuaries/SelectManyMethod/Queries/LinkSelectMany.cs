using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQuaries.SelectManyMethod.Queries
{
    internal class LinkSelectMany
    {
        internal static void ExecuteLinkSelectMany()
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
                    Console.WriteLine($"Employee Name: {employee.FirstName} - Employee Annual Salary: {employee.AnnualSalary}");
                }
            }
            else
            {
                Console.WriteLine("No employees found with the same annual salary.");
            }
        }
    }
}
