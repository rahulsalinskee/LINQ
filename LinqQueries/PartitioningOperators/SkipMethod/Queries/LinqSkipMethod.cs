using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.PartitioningOperators.SkipMethod.Queries
{
    internal class LinqSkipMethod
    {
        internal static void ExecuteSkip()
        {
            Console.WriteLine("\n--------------------- Skip ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Skip Method \n\n");

            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = list.Skip(4);

            foreach (var item in result)
            {
                Console.WriteLine("Skip: " + item);
            }

            var employees = GenerateData.GetEmployees();

            var employeesNotManager = employees.Where(employee => employee.IsManager is not true).Skip(2).ToList();

            foreach (var employee in employeesNotManager)
            {
                Console.WriteLine($"\nEmployee Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}, Is Manager: {employee.IsManager}");
            }
        }
    }
}
