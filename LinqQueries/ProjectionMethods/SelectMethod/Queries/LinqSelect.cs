using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.ProjectionMethods.SelectMethod.Queries
{
    internal static class LinqSelect
    {
        internal static void ExecuteLinqSelect()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------- Select ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Link Select \n\n");
            var employees = GenerateData.GetEmployees();

            /*  Returns the count of duplicated employees with the  name */
            var duplicatedEmployees = employees.GroupBy(employee => employee.FirstName).Where(employee => employee.Count() > 1).Select(employee => new { FirstName = employee.Key, Count = employee.Count() }).ToList();

            foreach (var duplicatedEmployee in duplicatedEmployees)
            {
                Console.WriteLine($"Duplicated Employee First Name: { duplicatedEmployee.FirstName } \ncount: { duplicatedEmployee.Count }");
            }
        }
    }
}
