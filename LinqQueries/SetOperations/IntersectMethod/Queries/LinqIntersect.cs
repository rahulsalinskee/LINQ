using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.SetOperations.IntersectMethod.Queries
{
    internal class LinqIntersect
    {
        internal static void ExecuteIntersect()
        {
            Console.WriteLine("\n--------------------- Intersect Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Intersect Method \n\n");

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>() { 4, 5, 6, 7, 8 };
            var results = list1.Intersect(list2);

            foreach (var item in results)
            {
                Console.WriteLine("Common/Intersected Numbers: " + item);
            }

            var employees = GenerateData.GetEmployees();
            var temporaryEmployees = GenerateData.GetEmployees();

            var intersectedEmployees = employees.Select(employee => new 
            { 
                FN = employee.FirstName, 
                LN = employee.LastName 
            }).Intersect(temporaryEmployees.Select(employee => new 
            { 
                FN = employee.FirstName, 
                LN = employee.LastName 
            })).ToList();

            foreach (var employee in intersectedEmployees)
            {
                Console.WriteLine($"\nCommon Employee:\n First Name: {employee.FN}\n Last Name: {employee.LN}");
            }
        }
    }
}