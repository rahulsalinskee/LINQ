using LINQ.LinqQueries.FilteringOperators.OfTypeMethod;
using LINQ.LinqQueries.FilteringOperators.WhereMethod.Queries;
using LINQ.LinqQueries.FilterMethod.Queries.FilterExtensionMethod;
using LINQ.LinqQueries.IQueryable.Queries;
using LINQ.LinqQueries.ProjectionMethods.SelectManyMethod.Queries;
using LINQ.LinqQueries.ProjectionMethods.SelectMethod.Queries;
using LINQ.LinqQueries.Sort.OrderBy.AsendingOrder.Queries;
using LINQ.LinqQueries.Sort.OrderBy.DescendingOrder.Queries;
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
            LinqSelectMany.ExecuteLinqSelectMany();
        }

        private static void RunSelect()
        {
            LinqSelect.ExecuteLinqSelect();
        }
        #endregion

        #region Filter Operator - Where
        private static void RunWhere()
        {
            LinqWhere.ExecuteWhereMethod();
        }
        
        private static void RunOfType()
        {
            LinqOfType.ExecuteOfTypeMethod();
        }
        #endregion

        #region Sorting Operators
        internal static void RunOrderByForAscending()
        {
            LinqOrderByForAscending.ExecuteOrderByForAscending();
        }
        
        internal static void RunOrderByForDescending()
        {
            LinqOrderByForDesending.ExecuteOrderByForDescending();
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
            RunOfType();
            RunOrderByForAscending();
            RunOrderByForDescending();
        }
        #endregion
    }
}
