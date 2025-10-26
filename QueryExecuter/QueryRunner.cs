using LINQ.FilterMethod.Queries.FilterExtensionMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.QueryExecuter
{
    internal static class QueryRunner
    {
        internal static void RunFilter()
        {
            Filter.ExecuteFilter();
        }
    }
}
