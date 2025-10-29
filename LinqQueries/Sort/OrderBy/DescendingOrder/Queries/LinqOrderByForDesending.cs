using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.Sort.OrderBy.DescendingOrder.Queries
{
    internal class LinqOrderByForDesending
    {
        internal static void ExecuteOrderByForDescending()
        {
            Console.WriteLine("\n--------------------- Sorting - Order By Descending  ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Order By Descending \n\n");

            var employees = GenerateData.GetEmployees();

            var sortedEmployees = employees.Where(employee => employee.AnnualSalary > 60000).Select(employee => new
            {
                FN = employee.FirstName,
                LN = employee.LastName
            }).OrderByDescending(employee => employee.FN).ToList();

            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"First Name : {employee.FN}, Last Name : {employee.LN}");
            }
        }
    }
}
