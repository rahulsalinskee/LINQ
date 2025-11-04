using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.ElementOperations.ElementAtOrDefaultMethod.Queries
{
    internal class LinqElementAtOrDefault
    {
        internal static void ExecuteElementAtOrDefault()
        {
            Console.WriteLine("\n--------------------- ElementAtOrDefault ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - ElementAtOrDefault \n\n");
            var employees = GenerateData.GetEmployees();
            try
            {
                var elementAtWithValidValueMethodSyntax = employees.ElementAtOrDefault(3);
                Console.WriteLine($"Element at index 3 using Method Syntax: {elementAtWithValidValueMethodSyntax?.FirstName}");
                var elementAtWithExceptionValueMethodSyntax = employees.ElementAtOrDefault(-3);
                Console.WriteLine($"Element at index -3 using Method Syntax: {elementAtWithExceptionValueMethodSyntax?.FirstName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Method Syntax Error: {ex.Message}");
            }
            try
            {
                var elementAtWithValidValueQuerySyntax = (from employee in employees select employee).ElementAtOrDefault(3);
                Console.WriteLine($"Element at index 3 using Query Syntax: {elementAtWithValidValueQuerySyntax?.FirstName}");
                var elementAtWithExceptionValueQuerySyntax = (from employee in employees select employee).ElementAtOrDefault(-3);
                Console.WriteLine($"Element at index -3 using Query Syntax: {elementAtWithExceptionValueQuerySyntax?.FirstName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query Syntax Error: {ex.Message}");
            }
        }
    }
}
