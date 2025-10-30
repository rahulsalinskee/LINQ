using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.SetOperations.DistinctMethod.Queries
{
    internal class LinqDistinct
    {
        internal static void ExecuteDistinct()
        {
            Console.WriteLine("\n--------------------- Distinct ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Distinct \n\n");

            var employees = GenerateData.GetEmployees();

            var uniqueEmployeesFirstName = employees.Where(employee => employee.IsManager).Select(employee => employee.FirstName).Distinct();

            foreach (var employeeFirstName in uniqueEmployeesFirstName)
            {
                Console.WriteLine($"Employee First Name: {employeeFirstName}");
            }
        }
    }
}
