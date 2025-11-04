using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.ElementOperations.FirstMethod.Queries
{
    internal class LinqFirst
    {
        internal static void ExecuteFirstMethod()
        {
            Console.WriteLine("\n--------------------- First ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - First \n\n");
            var employees = Utility.GenerateData.GetEmployees();
            try
            {
                var firstMethodSyntax = employees.First(employee => employee.FirstName.StartsWith("J"));
                Console.WriteLine($"First using Method Syntax: {firstMethodSyntax?.FirstName}");

                var firstNoMatchMethodSyntax = employees.First(employee => employee.FirstName.StartsWith("Z"));
                Console.WriteLine($"First with no match using Method Syntax: {firstNoMatchMethodSyntax?.FirstName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Method Syntax Error: {ex.Message}");
            }
            try
            {
                var firstQuerySyntax = (from employee in employees where employee.FirstName.StartsWith("J") select employee).First();
                Console.WriteLine($"First using Query Syntax: {firstQuerySyntax?.FirstName}");

                var firstNoMatchQuerySyntax = (from employee in employees where employee.FirstName.StartsWith("Z") select employee).First();
                Console.WriteLine($"First with no match using Query Syntax: {firstNoMatchQuerySyntax?.FirstName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query Syntax Error: {ex.Message}");
            }
        }
    }
}
