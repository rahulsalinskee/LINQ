using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.SetOperations.UnionMethod.Queries
{
    internal class LinqUnionMethod
    {
        internal static void ExecuteUnionMethod()
        {
            Console.WriteLine("\n--------------------- Union Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Union Method \n\n");

            List<int> firstList = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> secondList = new List<int>() { 4, 5, 6, 7, 8 };
            var unionList = firstList.Union(secondList).ToList();
            Console.WriteLine("Union of First List and Second List:");
            foreach (var number in unionList)
            {
                Console.WriteLine(number);
            }

            var employees = GenerateData.GetEmployees();

            var temporaryEmployees = GenerateData.GetEmployees();

            var unionedEmployees = employees.Union(temporaryEmployees).ToList();

            foreach(var employee in unionedEmployees)
            {
                Console.WriteLine($"\nEmployee:\n First Name: {employee.FirstName}\n Last Name: {employee.LastName}");
            }
        }
    }
}
