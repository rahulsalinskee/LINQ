using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.FilterMethod.Extensions
{
    public static class FilterExtension
    {
        public static IList<T> Filter<T>(this IEnumerable<T> records, Func<T, bool> condition)
        {
            IList<T> filteredRecords = new List<T>();

            foreach (T record in records)
            {
                if (condition(record))
                {
                    filteredRecords.Add(record);
                }
            }
            return filteredRecords;
        }
    }
}
