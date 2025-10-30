using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.QuantifierOperators.AnyMethod.Queries
{
    internal class LinqAny
    {
        internal static void ExecuteAny()
        {
            Console.WriteLine("\n--------------------- Any Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Any Method \n\n");

            // Using LINQ Any method to check if there are any even numbers in the list
            var employees = GenerateData.GetEmployees();

            var isEmployeeItManager = employees.Where(employee => employee?.Department?.ShortName == "IT").Select(employee => new
            {
                FN = employee.FirstName,
                LN = employee.LastName,
                DepartmentName = employee?.Department?.ShortName,
                Salary = employee?.AnnualSalary,
                IsManager = employee?.IsManager
            }).Any(employee => employee.IsManager is true);

            if (isEmployeeItManager)
            {
                Console.WriteLine("There is an employee who is in IT and Manager");
            }
            else
            {
                Console.WriteLine("There is NO employee who is in IT and Manager");
            }
        }
    }
}
