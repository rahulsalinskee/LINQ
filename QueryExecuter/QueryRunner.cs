using LINQ.LinqQueries.FilteringOperators.OfTypeMethod;
using LINQ.LinqQueries.FilteringOperators.WhereMethod.Queries;
using LINQ.LinqQueries.FilterMethod.Queries.FilterExtensionMethod;
using LINQ.LinqQueries.IQueryable.Queries;
using LINQ.LinqQueries.ProjectionMethods.SelectManyMethod.Queries;
using LINQ.LinqQueries.ProjectionMethods.SelectMethod.Queries;
using LINQ.LinqQueries.Sort.OrderBy.AscendingOrder.Queries;
using LINQ.LinqQueries.Sort.OrderBy.DescendingOrder.Queries;
using LINQ.LinqQueries.Sort.ReverseMethod.Queries;
using LINQ.LinqQueries.Sort.ThenBy.AscendingOrder.Queries;
using LINQ.LinqQueries.Sort.ThenBy.DescendingOrder.Queries;
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
        private static void RunOrderByForAscending()
        {
            LinqOrderByForAscending.ExecuteOrderByForAscending();
        }
        
        private static void RunOrderByForDescending()
        {
            LinqOrderByForDesending.ExecuteOrderByForDescending();
        }

        private static void RunThenByForAscending()
        {
            LinqThenByAscending.ExecuteThenByAscending();
        }
        
        private static void RunThenByForDescending()
        {
            LinqThenByDescending.ExecuteThenByDescending();
        }

        private static void RunLinqReverse()
        {
            LinqReverseMethod.ExecuteReverse();
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
            RunThenByForAscending();
            RunThenByForDescending();
            RunLinqReverse();
        }
        #endregion
    }
}
