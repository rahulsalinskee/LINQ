using LINQ.Utility;
using LINQ.Utility.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.SetOperations.UnionMethod.ComparerQueries
{
    internal class LinqUnionComparer
    {
        internal static void ExecuteUnionComparer()
        {
            Console.WriteLine("\n--------------------- Union Comparer Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Union Comparer Method \n\n");

            var employees = GenerateData.GetEmployees();

            var temporaryEmployees = GenerateData.GetEmployees();

            var unionedEmployees = employees.Union(temporaryEmployees, new EmployeeComparer()).ToList();

            foreach (var employee in unionedEmployees)
            {
                Console.WriteLine($"\nEmployee:\n First Name: {employee.FirstName}\n Last Name: {employee.LastName}");
            }
        }
    }
}
