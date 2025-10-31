using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.PartitioningOperators.TakeWhileMethod.Queries
{
    internal class LinqTakeWhileMethod
    {
        internal static void ExecuteTakeWhile()
        {
            Console.WriteLine("\n--------------------- TakeWhile Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - TakeWhile Method \n\n");

            var numbers = new List<int> { 1, 2, 5, 7, 9, 2, 4, 6, 8, 3, 10 };

            /* Take While */
            var takenNumbersUsingTakeWhile = numbers.TakeWhile(number => number > 6);

            Console.WriteLine("Numbers less than 6 taken using TakeWhile:\n");
            foreach (var number in takenNumbersUsingTakeWhile)
            {
                Console.WriteLine(number + "\n");
            }

            /* Where */
            var takenNumbersUsingWhere = numbers.Where(number => number > 6);

            Console.WriteLine("Numbers less than 6 taken using Where:\n");
            foreach (var number in takenNumbersUsingWhere)
            {
                Console.WriteLine(number + "\n");
            }

            var employees = GenerateData.GetEmployees();
            var employeesName = employees.TakeWhile((employee, index) => employee.FirstName.Length > index);
            foreach (var employee in employeesName)
            {
                Console.WriteLine("Employee Name: " + employee.FirstName + " " + employee.LastName);
            }
        }
    }
}
