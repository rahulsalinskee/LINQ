using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.PartitioningOperators.SkipWhileMethod.Queries
{
    internal class LinqSkipWhile
    {
        internal static void ExecuteSkipWhile()
        {
            Console.WriteLine("\n--------------------- SkipWhile Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - SkipWhile Method \n\n");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            var result = numbers.SkipWhile(x => x < 5);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var employees = GenerateData.GetEmployees();

            var filteredEmployees = employees.Select(employee => new 
            { 
                FN = employee.FirstName, 
                LN = employee.LastName,
            }).SkipWhile((employee, index) => employee.FN.Length == index).ToList();

            foreach (var item in filteredEmployees)
            {
                Console.WriteLine("\nEmployee Name: " + item.FN + " " + item.LN);
            }
        }
    }
}
