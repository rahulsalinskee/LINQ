using LINQ.Utility;
using LINQ.Utility.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.SetOperations.ExceptMethod.ComparerQueries
{
    internal class LinqExceptComparer
    {
        internal static void ExecuteExceptComparer()
        {
            Console.WriteLine("\n--------------------- Except Comparer Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Except Comparer Method \n\n");

            var employees = GenerateData.GetEmployees();

            /* Here, Both the employees and temporary employees are the same, hence the output will be empty.
            *  But if the employees and temporary employees are different, then the output will be different.
            *  And this is the syntax of the Except method for comparer.
            */
            var temporaryEmployees = GenerateData.GetEmployees();

            var exceptEmployees = employees.Except(temporaryEmployees, new EmployeeComparer());

            foreach (var employee in exceptEmployees)
            {
                Console.WriteLine($"First Name: {employee.FirstName}");
            }
        }
    }
}
