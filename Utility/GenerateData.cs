using LINQ.Models.Department;
using LINQ.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Utility
{
    internal class GenerateData
    {
        internal static IEnumerable<Employee> GenerateEmployees()
        {
            return Employees();
        }

        internal static IEnumerable<Department> GenerateDepartments()
        {
            return Departments();
        }

        private static IEnumerable<Employee> Employees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", DepartmentId = 1, AnnualSalary = 60000, IsManager = false },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", DepartmentId = 2, AnnualSalary = 80000, IsManager = true },
                new Employee { Id = 3, FirstName = "Sam", LastName = "Davis", DepartmentId = 1, AnnualSalary = 55000, IsManager = false },
                new Employee { Id = 4, FirstName = "Ava", LastName = "Johnson", DepartmentId = 3, AnnualSalary = 95000, IsManager = true },
                new Employee { Id = 5, FirstName = "Tom", LastName = "Davis", DepartmentId = 4, AnnualSalary = 72000, IsManager = false },
                new Employee { Id = 6, FirstName = "Emily", LastName = "Miller", DepartmentId = 1, AnnualSalary = 58000, IsManager = false },
                new Employee { Id = 7, FirstName = "Mark", LastName = "Wilson", DepartmentId = 3, AnnualSalary = 88000, IsManager = true },
                new Employee { Id = 8, FirstName = "Sara", LastName = "Anderson", DepartmentId = 4, AnnualSalary = 75000, IsManager = false },
                new Employee { Id = 9, FirstName = "Kevin", LastName = "Taylor", DepartmentId = 5, AnnualSalary = 59000, IsManager = false },
                new Employee { Id = 10, FirstName = "Ava", LastName = "Davis", DepartmentId = 5, AnnualSalary = 85000, IsManager = true },
            };
        }

        private static IEnumerable<Department> Departments()
        {
            return new List<Department>
            {
                new Department { Id = 1, ShortName = "HR", LongName = "Human Resources" },
                new Department { Id = 2, ShortName = "Sales", LongName = "Sales and Marketing" },
                new Department { Id = 3, ShortName = "IT", LongName = "Information Technology" },
                new Department { Id = 4, ShortName = "Finance", LongName = "Finance and Accounting" },
                new Department { Id = 5, ShortName = "Admin", LongName = "Administrative Services" }
            };
        }
    }
}
