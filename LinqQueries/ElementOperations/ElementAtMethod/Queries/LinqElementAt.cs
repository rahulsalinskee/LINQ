using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.ElementOperations.ElementAtMethod.Queries
{
    internal class LinqElementAt
    {
        internal static void ExecuteElementAt()
        {
            Console.WriteLine("\n--------------------- ElementAt ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - ElementAt \n\n");
            var employees = GenerateData.GetEmployees();
            try
            {
                var elementAtWithValidValueMethodSyntax = employees.ElementAt(3);
                Console.WriteLine($"Element at index 3 using Method Syntax: {elementAtWithValidValueMethodSyntax?.FirstName}");
                var elementAtWithExceptionValueMethodSyntax = employees.ElementAt(-3);
                Console.WriteLine($"Element at index -3 using Method Syntax: {elementAtWithExceptionValueMethodSyntax?.FirstName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Method Syntax Error: {ex.Message}");
            }
            try
            {
                var elementAtWithValidValueQuerySyntax = (from employee in employees select employee).ElementAt(3);
                Console.WriteLine($"Element at index 3 using Query Syntax: {elementAtWithValidValueQuerySyntax?.FirstName}");
                var elementAtWithExceptionValueQuerySyntax = (from employee in employees select employee).ElementAt(-3);
                Console.WriteLine($"Element at index -3 using Query Syntax: {elementAtWithExceptionValueQuerySyntax?.FirstName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query Syntax Error: {ex.Message}");
            }
        }
    }
}
