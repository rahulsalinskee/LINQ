using LINQ.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models.Address
{
    internal class Address
    {
        public int Id { get; set; }

        public string AddressLine1 { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string ZipCode { get; set; } = string.Empty;

        public int EmployeeId { get; set; }

        public Employee.Employee? Employees { get; set; }
    }
}
