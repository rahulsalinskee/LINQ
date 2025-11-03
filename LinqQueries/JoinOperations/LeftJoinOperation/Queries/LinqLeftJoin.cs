using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.JoinOperations.LeftJoinOperation.Queries
{
    internal class LinqLeftJoin
    {
        internal static void ExecuteLeftJoin()
        {
            Console.WriteLine("\n--------------------- Left Join ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Left Join \n\n");

            var employees = GenerateData.GetEmployees();

            var departments = GenerateData.GetDepartments();

            var leftJoinQuerySyntax = 
                (from employee in employees
                    join
                        department in departments
                            on
                                employee?.Department?.Id equals department.Id
                                    into 
                                        employeeDepartmentGroup
                                            from department in employeeDepartmentGroup.DefaultIfEmpty()
                    select new
                    {
                        EmployeeName = employee.FirstName + " " + employee.LastName,
                        DepartmentName = department != null ? department.ShortName : "No Department"
                    }
                ).ToList();

            Console.WriteLine("Using Query Syntax: ");
            foreach (var employee in leftJoinQuerySyntax)
            {
                Console.WriteLine($"Name: {employee.EmployeeName}, Department: {employee.DepartmentName}");
            }
        }
    }
}
