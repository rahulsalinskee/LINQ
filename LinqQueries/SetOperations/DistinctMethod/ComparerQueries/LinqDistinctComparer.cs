using LINQ.Utility;
using LINQ.Utility.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.SetOperations.DistinctMethod.ComparerQueries
{
    internal class LinqDistinctComparer
    {
        internal static void ExecuteDistinctComparer()
        {
            Console.WriteLine("\n--------------------- Distinct Comparer ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Distinct Comparer \n\n");
            // Implementation will go here in the future

            var employees = GenerateData.GetEmployees();

            EmployeeComparer employeeComparer = new();

            var uniqueEmployeesFirstName = employees.Distinct(employeeComparer).ToList();

            foreach (var employee in uniqueEmployeesFirstName)
            {
                Console.WriteLine($"First Name: {employee.FirstName}");
            }
        }
    }
}
