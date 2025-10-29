using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.IQueryable.Queries
{
    internal static class LinqQueryable
    {
        internal static void RunQueryable()
        {
            Console.WriteLine("--------------------- IQueryable ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - IQueryable \n\n");

            var employees = GenerateData.GetEmployees();

            var filteredQueriedEmployees = employees.Where(employee => employee.AnnualSalary > 60000 && employee.IsManager is true).AsQueryable();
            foreach (var queriedEmployee in filteredQueriedEmployees)
            {
                Console.WriteLine(queriedEmployee.Id + ". " + queriedEmployee.FirstName + " " + queriedEmployee.LastName);
            }
        }
    }
}
