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
        internal static IEnumerable<Employee> GetEmployees()
        {
            return Employees();
        }

        private static IEnumerable<Employee> Employees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1, FirstName = "John", LastName = "Doe", AnnualSalary = 60000, IsManager = false,
                    Department = Departments().FirstOrDefault(department => department.Id == 5),
                },
                new Employee
                {
                    Id = 2, FirstName = "Jane", LastName = "Smith", AnnualSalary = 80000, IsManager = true,
                    Department = Departments().FirstOrDefault(department => department.Id == 2),
                },
                new Employee
                {
                    Id = 3, FirstName = "Sam", LastName = "Davis", AnnualSalary = 55000, IsManager = false,
                    Department = Departments().FirstOrDefault(department => department.Id == 1),
                },
                new Employee
                {
                    Id = 4, FirstName = "Ava", LastName = "Johnson", AnnualSalary = 95000, IsManager = true,
                    Department = Departments().FirstOrDefault(department => department.Id == 3),
                },
                new Employee
                {
                    Id = 5, FirstName = "Tom", LastName = "Davis", AnnualSalary = 72000, IsManager = false,
                    Department = Departments().FirstOrDefault(department => department.Id == 4),
                },
                new Employee
                {
                    Id = 6, FirstName = "Emily", LastName = "Miller", AnnualSalary = 58000, IsManager = false,
                    Department = Departments().FirstOrDefault(department => department.Id == 1),
                },
                new Employee
                {
                    Id = 7, FirstName = "Mark", LastName = "Wilson", AnnualSalary = 88000, IsManager = true,
                    Department = Departments().FirstOrDefault(department => department.Id == 3)
                },
                new Employee
                {
                    Id = 8, FirstName = "Sara", LastName = "Anderson", AnnualSalary = 75000, IsManager = false,
                    Department = Departments().FirstOrDefault(department => department.Id == 4),
                },
                new Employee
                {
                    Id = 9, FirstName = "Kevin", LastName = "Taylor", AnnualSalary = 59000, IsManager = false,
                    Department = Departments().FirstOrDefault(department => department.Id == 5)
                },
                new Employee 
                { 
                    Id = 10, FirstName = "Ava", LastName = "Davis", AnnualSalary = 85000, IsManager = true, 
                    Department = Departments().FirstOrDefault(department => department.Id == 5) 
                },
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
