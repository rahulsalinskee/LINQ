using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.FilteringOperators.WhereMethod.Queries
{
    internal class LinqWhere
    {
        internal static void ExecuteWhereMethod()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------- Filtering Operator - Where ----------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Where \n\n");
            var employees = GenerateData.GetEmployees();
            var filteredEmployees = employees.Where(employee => employee?.LastName?.Length > 5 && employee.AnnualSalary > 60000 && employee.IsManager is true);
            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
        }
    }
}
