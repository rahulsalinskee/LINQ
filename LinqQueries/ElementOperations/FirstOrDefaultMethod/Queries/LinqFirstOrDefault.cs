using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.ElementOperations.FirstOrDefaultMethod.Queries
{
    internal class LinqFirstOrDefault
    {
        internal static void ExecuteFirstOrDefaultMethod()
        {
            Console.WriteLine("\n--------------------- FirstOrDefault ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - FirstOrDefault \n\n");
            var employees = Utility.GenerateData.GetEmployees();
            try
            {
                var firstOrDefaultMethodSyntax = employees.FirstOrDefault(employee => employee.FirstName.StartsWith("J"));
                Console.WriteLine($"FirstOrDefault using Method Syntax: {firstOrDefaultMethodSyntax?.FirstName}");

                var firstOrDefaultNoMatchMethodSyntax = employees.FirstOrDefault(employee => employee.FirstName.StartsWith("Z"));
                Console.WriteLine($"FirstOrDefault with no match using Method Syntax: {firstOrDefaultNoMatchMethodSyntax?.FirstName ?? "No Match Found"}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Method Syntax Error: {ex.Message}");
            }
            try
            {
                var firstOrDefaultQuerySyntax = (from employee in employees where employee.FirstName.StartsWith("J") select employee).FirstOrDefault();
                Console.WriteLine($"FirstOrDefault using Query Syntax: {firstOrDefaultQuerySyntax?.FirstName}");

                var firstOrDefaultNoMatchQuerySyntax = (from employee in employees where employee.FirstName.StartsWith("Z") select employee).FirstOrDefault();
                Console.WriteLine($"FirstOrDefault with no match using Query Syntax: {firstOrDefaultNoMatchQuerySyntax?.FirstName ?? "No Match Found"}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query Syntax Error: {ex.Message}");
            }
        }
    }
}
