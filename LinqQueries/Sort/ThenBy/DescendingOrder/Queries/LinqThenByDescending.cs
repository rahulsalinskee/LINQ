using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.Sort.ThenBy.DescendingOrder.Queries
{
    internal class LinqThenByDescending
    {
        internal static void ExecuteThenByDescending()
        {
            Console.WriteLine("\n--------------------- Sorting - Then By Descending  ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Then By Descending \n\n");

            var employees = GenerateData.GetEmployees();

            var sortedEmployees = employees.Where(employee => employee.IsManager is true).Select(employee => new
            {
                FN = employee.FirstName,
                LN = employee.LastName,
                DepartmentName = employee?.Department?.ShortName
            }).OrderBy(employee => employee.FN).ThenByDescending(employee => employee.LN).ToList();

            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"First Name : {employee.FN}, Last Name : {employee.LN}, Department Name : {employee.DepartmentName}");
            }
        }
    }
}
