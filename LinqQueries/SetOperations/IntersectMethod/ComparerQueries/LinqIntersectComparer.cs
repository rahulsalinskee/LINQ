using LINQ.Utility;
using LINQ.Utility.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.SetOperations.IntersectMethod.ComparerQueries
{
    internal class LinqIntersectComparer
    {
        internal static void ExecuteIntersectComparer()
        {
            Console.WriteLine("\n--------------------- Intersect Method Comparer ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Intersect Comparer Method \n\n");

            var employees = GenerateData.GetEmployees();
            var temporaryEmployees = GenerateData.GetEmployees();

            var intersectedEmployees = employees.Intersect(temporaryEmployees, new EmployeeComparer()).ToList();

            foreach (var employee in intersectedEmployees)
            {
                Console.WriteLine($"\nCommon Employee:\n First Name: {employee.FirstName}\n Last Name: {employee.LastName}");
            }
        }
    }
}
