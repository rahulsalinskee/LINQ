using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.PartitioningOperators.TakeOperator.Queries
{
    internal class LinqTakeMethod
    {
        internal static void ExecuteTake()
        {
            Console.WriteLine("\n--------------------- Take Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Take Method \n\n");

            var employees = GenerateData.GetEmployees();

            var firstThreeEmployees = employees.Take(2);

            Console.WriteLine("First 2 Employees are: \n");
            foreach (var employee in firstThreeEmployees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + "\n");
            }

            Console.WriteLine("\nFirst 4 Managers are: \n");

            var firstThreeManagers = employees.Where(employee => employee.IsManager).Take(4);

            foreach (var employee in firstThreeManagers)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + "\n");
            }
        }
    }
}
