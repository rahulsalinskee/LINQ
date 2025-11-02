using LINQ.Models.Address;
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

        internal static IEnumerable<Department> GetDepartments()
        {
            return Departments();
        }

        internal static IEnumerable<Address> GetAddresses()
        {
            return Addresses();
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

        private static IEnumerable<Address> Addresses()
        {
            return new List<Address>
            {
                new Address { Id = 1, AddressLine1 = "123 Main St", City = "New York", State = "NY", ZipCode = "10001", EmployeeId = 1 },
                new Address { Id = 2, AddressLine1 = "298 Birch St", City = "San Francisco", State = "CA", ZipCode = "94101", EmployeeId = 9 },
                new Address { Id = 3, AddressLine1 = "321 Maple Dr", City = "Houston", State = "TX", ZipCode = "77001", EmployeeId = 4 },
                new Address { Id = 4, AddressLine1 = "789 Pine Rd", City = "Chicago", State = "IL", ZipCode = "60601", EmployeeId = 3 },
                new Address { Id = 5, AddressLine1 = "456 Oak Ave", City = "Los Angeles", State = "CA", ZipCode = "90001", EmployeeId = 2 },
                new Address { Id = 6, AddressLine1 = "654 Cedar Ln", City = "Miami", State = "FL", ZipCode = "33101", EmployeeId = 5 },
                new Address { Id = 7, AddressLine1 = "985 Zipped St", City = "San Francisco", State = "CA", ZipCode = "94101", EmployeeId = 6 },
                new Address { Id = 8, AddressLine1 = "253 Berth St", City = "San Francisco", State = "CA", ZipCode = "94101", EmployeeId = 10 },
                new Address { Id = 9, AddressLine1 = "246 Birch St", City = "San Francisco", State = "CA", ZipCode = "94101", EmployeeId = 7 },
                new Address { Id = 10, AddressLine1 = "288 Barth St", City = "San Francisco", State = "CA", ZipCode = "94101", EmployeeId = 8 },
            };
        }
    }
}
