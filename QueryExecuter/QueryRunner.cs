using LINQ.LinqQuaries.FilteringOperators.WhereMethod.Queries;
using LINQ.LinqQuaries.FilterMethod.Queries.FilterExtensionMethod;
using LINQ.LinqQuaries.IQueryable.Queries;
using LINQ.LinqQuaries.ProjectionMethods.SelectManyMethod.Queries;
using LINQ.LinqQuaries.ProjectionMethods.SelectMethod.Queries;
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

        #region Run Projection - Select Many
        private static void RunSelectMany()
        {
            LinqSelectMany.ExecuteLinkSelectMany();
        }

        private static void RunSelect()
        {
            LinqSelect.ExecuteLinkSelect();
        }
        #endregion

        #region Filter Operator - Where
        private static void RunWhere()
        {
            LinqWhere.ExecuteWhereMethod();
        } 
        #endregion

        #region Run All Queries
        internal static void RunAllQueries()
        {
            RunFilter();
            RunIQueryable();
            RunSelectMany();
            RunSelect();
            RunWhere();
        }
        #endregion
    }
}
