using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.JoinOperations.InnerJoinWithMultipleTables.Queries
{
    internal class LinqInnerJoinInMultipleTables
    {
        internal static void ExecuteInnerJoinInMultipleTables()
        {
            Console.WriteLine("\n--------------------- Inner Join With Multiple Tables ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Inner Join With Multiple Tables \n\n");

            var employees = Utility.GenerateData.GetEmployees();

            var departments = Utility.GenerateData.GetDepartments();

            var addresses = Utility.GenerateData.GetAddresses();

            /* Method Syntax */
            var innerJoinMultipleTablesQueryMethodSyntax = employees    /* Table 1 = Employees = ID, FirstName, LastName, IsManager, Department */
                .Join(
                    departments,                                        /* Table 2 = Departments - ID, ShortName, LongName */
                    employee => employee?.Department?.Id,               /* Table 1 (Employees) contains [A Foreign Key To] Table 2 (Departments) */
                    department => department.Id,
                    (employee, department) => new                       /* Result selector - combine employee and department */
                    {
                        Employee = employee,
                        Department = department
                    }
                )
                .Join(
                    addresses,                                          /* Table 3 = Addresses = ID, AddressLine1, AddressLine2, City, State, Zip */
                    temp => temp.Employee.Id,                           /* Table 1 (Employees) ID */
                    address => address.EmployeeId,                      /* Table 3 (Addresses) contains [A Foreign Key To] Table 1 (Employees) */
                    (temp, address) => new                              /* Project these data (columns) from each table */
                    {
                        EmployeeName = temp.Employee.FirstName + " " + temp.Employee.LastName,
                        DepartmentName = temp.Department.ShortName,
                        AddressLine1 = address.AddressLine1,
                        City = address.City
                    }
                ).ToList();

            Console.WriteLine("Method Syntax: \n");
            foreach (var query in innerJoinMultipleTablesQueryMethodSyntax)
            {
                Console.WriteLine(
                    $"Employee Name: {query.EmployeeName}, \n" +
                    $"Department Name: {query.DepartmentName}, \n" +
                    $"Address: {query.AddressLine1}, \n" +
                    $"City: {query.City} \n\n"
                    );
            }

            /* Query Syntax */
            var innerJoinMultipleTablesQuerySyntax = 
                (
                    from employee in employees          /* Table 1 = Employees - ID, FirstName, LastName, AnnualSalary, Department, IsManager, etc. */
                        join 
                            department in departments   /* Table 2 = Departments - ID, ShortName, LongName */
                                on 
                            employee?.Department?.Id    /* Table 1 (Employees) contains [A Foreign Key To] Table 2 (Departments) */
                        equals 
                            department.Id
                        join 
                            address in addresses        /* Table 3 = Addresses = ID, AddressLine1, AddressLine2, City, State, Zip */
                                on 
                            employee.Id                 /* Table 1 (Employees) ID */
                        equals 
                            address.EmployeeId          /* Table 3 (Addresses) contains [A Foreign Key To] Table 1 (Employees) */
                    select new                          /* Project these data (columns) from each table */
                    {
                        EmployeeName = employee.FirstName + " " + employee.LastName,
                        DepartmentName = department.ShortName,
                        AddressLine1 = address.AddressLine1,
                        City = address.City
                    }
                ).ToList();

            Console.WriteLine("Query Syntax: \n");
            foreach (var query in innerJoinMultipleTablesQuerySyntax)
            {
                Console.WriteLine(
                    $"Employee Name: {query.EmployeeName}, \n" +
                    $"Department Name: {query.DepartmentName}, \n" +
                    $"Address: {query.AddressLine1}, \n" +
                    $"City: {query.City} \n\n"
                    );
            }
        }
    }
}
