using LINQ.Models.Employee;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.QuantifierOperators.ContainsComparer.Comparer
{
    internal class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }

            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Id == y.Id && x.FirstName == y.FirstName && x.LastName == y.LastName && x.Department?.ShortName == y.Department?.ShortName;    
        }

        public int GetHashCode([DisallowNull] Employee employee)
        {
            if (object.ReferenceEquals(employee, null))
            {
                return 0;
            }

            int idHashCode = employee.Id.GetHashCode();
            int firstNameHashCode = employee.FirstName.GetHashCode();
            int lastNameHashCode = employee.LastName.GetHashCode();
            int departmentNameHashCode = employee?.Department?.ShortName.GetHashCode() ?? 0;

            return idHashCode ^ firstNameHashCode ^ lastNameHashCode ^ departmentNameHashCode;
        }
    }
}
