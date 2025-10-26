using LINQ.LinqQuaries.FilterMethod.Queries.FilterExtensionMethod;
using LINQ.LinqQuaries.IQueryable.Queries;
using LINQ.LinqQuaries.SelectManyMethod.Queries;
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
        private static void RunFilter()
        {
            Filter.ExecuteFilter();
        }
        #endregion

        #region Run Queryable
        private static void RunIQueryable()
        {
            LinqQueryable.RunQueryable();
        }
        #endregion

        #region Run Select Many
        private static void RunSelectMany()
        {
            LinkSelectMany.ExecuteLinkSelectMany();
        }
        #endregion

        #region Run All Queries
        internal static void RunAllQueries()
        {
            RunFilter();
            RunIQueryable();
            RunSelectMany();
        } 
        #endregion
    }
}
