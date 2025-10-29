using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.Sort.OrderBy.AscendingOrder.Queries
{
    internal class LinqOrderByForAscending
    {
        internal static void ExecuteOrderByForAscending()
        {
            Console.WriteLine("\n--------------------- Sorting - Order By Ascending ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Order By \n\n");

            var employees = GenerateData.GetEmployees();

            var sortedEmployees = employees.Where(employee => employee.AnnualSalary > 60000).Select(employee => new 
            { 
                FN = employee.FirstName, 
                LN = employee.LastName 
            }).OrderBy(employee => employee.FN).ToList();

            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"First Name : {employee.FN}, Last Name : {employee.LN}");
            }
        }
    }
}
