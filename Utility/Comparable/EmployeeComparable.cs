using LINQ.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Utility.Comparable
{
    internal class EmployeeComparable : IEquatable<Employee>
    {
        internal int Id { get; set; }

        internal string FirstName { get; set; }

        public bool Equals(Employee? other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            int idHashCode = Id.GetHashCode();
            int firstNameHashCode = FirstName?.GetHashCode() ?? 0;

            return idHashCode ^ firstNameHashCode;
        }
    }
}
