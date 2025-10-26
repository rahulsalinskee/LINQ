using LINQ.FilterMethod.Queries.FilterExtensionMethod;
using LINQ.IQueryable.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.QueryExecuter
{
    internal static class QueryRunner
    {
        #region Run Filter
        internal static void RunFilter()
        {
            Filter.ExecuteFilter();
        }
        #endregion

        #region Run Queryable
        internal static void RunIQueryable()
        {
            LinqQueryable.RunQueryable();
        } 
        #endregion
    }
}
