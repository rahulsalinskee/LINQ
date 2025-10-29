using LINQ.Models.Department;
using LINQ.Models.Employee;
using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQuaries.FilteringOperators.OfTypeMethod
{
    internal class LinqOfType
    {
        internal static void ExecuteOfTypeMethod()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------- OfType ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - OfType \n\n");
            var employees = GenerateData.GetEmployees();

            var filteredEmployees = employees.OfType<Employee>().ToList();

            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine($"Employee Full Name: {employee.FirstName + " " + employee.LastName}");
            }

            IList<object> filteredRecords = new List<object>()
            {
                "This is a string",
                42,
                new Employee() { Id = 2, FirstName = "Jane", LastName = "Smith", AnnualSalary = 60000, IsManager = true },
                3.14,
                new Department() { Id = 1, ShortName = "HR", LongName = "Human Resources" }
            };

            var filteredEmployeeRecord = filteredRecords.OfType<Employee>().ToList();

            foreach (var employeeRecord in filteredEmployeeRecord)
            {
                Console.WriteLine($"Employee Record: {employeeRecord.FirstName}");
            }

            var filteredDepartmentRecord = filteredRecords.OfType<Department>().ToList();

            foreach (var departmentRecord in filteredDepartmentRecord)
            {
                Console.WriteLine($"Department Record: {departmentRecord.LongName}");
            }
        }
    }
}
