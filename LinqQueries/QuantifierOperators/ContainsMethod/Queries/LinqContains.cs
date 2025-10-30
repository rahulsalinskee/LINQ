using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.QuantifierOperators.ContainsMethod.Queries
{
    internal class LinqContains
    {
        internal static void ExecuteContains()
        {
            Console.WriteLine("\n------------------- Contains Method -------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Contains Method \n\n");

            var employees = GenerateData.GetEmployees();

            var targetEmployees = employees.FirstOrDefault(employee => employee.FirstName == "John" && employee.LastName == "Doe" && employee?.Department?.ShortName == "Admin");

            var isEmployeeFound = employees.Contains(targetEmployees);

            Console.WriteLine($"Is Employee Found: {isEmployeeFound}");
        }
    }
}
