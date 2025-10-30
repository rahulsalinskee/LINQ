using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.QuantifierOperators.AllMethod.Queries
{
    internal class LinqAll
    {
        internal static void ExecuteAll()
        {
            Console.WriteLine("\n--------------------- All Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - All Method \n\n");

            var employees = GenerateData.GetEmployees();

            var areAllEmployeesInIT = employees.Select(employee => new
            {
                FN = employee.FirstName,
                LN = employee.LastName,
                DepartmentName = employee?.Department?.ShortName
            }).All(employee => employee.DepartmentName == "IT");

            Console.WriteLine($"1. Are all employees in IT department? {areAllEmployeesInIT}");

            var isAnItEmployee = employees.Where(employee => employee?.Department?.ShortName == "IT").Select(employee => new
            {
                FN = employee.FirstName,
                LN = employee.LastName,
                DepartmentName = employee?.Department?.ShortName
            }).All(employee => employee.FN != null);

            Console.WriteLine($"2. Is an IT Employee: {isAnItEmployee}");

            var areLastNamesNotNull = employees.Select(employee => new
            {
                FN = employee.FirstName,
                LN = employee.LastName,
                DepartmentName = employee?.Department?.ShortName
            }).All(employee => employee.LN != null);

            Console.WriteLine($"3. Are last names of employees not NULL? {areLastNamesNotNull}");
        }
    }
}
