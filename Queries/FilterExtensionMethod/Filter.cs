using LINQ.Extensions;
using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Queries.FilterExtensionMethod
{
    internal static class Filter
    {
        internal static void ExecuteFilter()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is Language Integrated Query For - Filter \n\n");
            var employees = GenerateData.GetEmployees();

            var filteredEmployees = employees.Filter(employee => employee.AnnualSalary > 60000 && employee.IsManager is true);

            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
        }
    }
}
