using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.JoinOperations.GroupJoinMethod.Queries
{
    internal class LinqGroupJoin
    {
        internal static void ExecuteGroupJoin()
        {
            Console.WriteLine("\n--------------------- Group Join ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Group Join \n\n");

            var employees = Utility.GenerateData.GetEmployees();

            var departments = Utility.GenerateData.GetDepartments();

            var groupJoinQueryMethodSyntax = departments
                .GroupJoin(employees,
                    department => department.Id,
                    employee => employee?.Department?.Id,
                    (department, empGroup) => new
                    {
                        DepartmentName = department.ShortName,
                        Employees = empGroup.Select(e => e.FirstName + " " + e.LastName).ToList()
                    }).ToList();

            Console.WriteLine("Using Method Syntax: ");
            foreach (var query in groupJoinQueryMethodSyntax)
            {
                Console.WriteLine($"Department Name: {query.DepartmentName}");
                foreach (var employeeName in query.Employees)
                {
                    Console.WriteLine($"Employee Name: {employeeName}");
                }
                Console.WriteLine();
            }

            var groupJoinQueryQuerySyntax = 
                from department in departments
                        join 
                            employee in employees 
                                on 
                                    department.Id equals employee?.Department?.Id 
                                into 
                            employeeGroup
                                select new
                                {
                                    DepartmentName = department.ShortName,
                                    Employees = employeeGroup.Select(employee => employee.FirstName + " " + employee.LastName).ToList()
                                };

            Console.WriteLine("Using Query Syntax: ");
            foreach (var query in groupJoinQueryQuerySyntax)
            {
                Console.WriteLine($"Department Name: {query.DepartmentName}");
                foreach (var employeeName in query.Employees)
                {
                    Console.WriteLine($"Employee Name: {employeeName}");
                }
                Console.WriteLine();
            }
        }
    }
}
