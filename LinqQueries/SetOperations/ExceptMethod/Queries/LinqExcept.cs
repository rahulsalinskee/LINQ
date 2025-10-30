using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.SetOperations.ExceptMethod.Queries
{
    internal class LinqExcept
    {
        internal static void ExecuteExcept()
        {
            Console.WriteLine("\n--------------------- Except Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Except Method \n\n");
            var firstCollection = new List<int> { 1, 2, 3, 4, 5 };
            var secondCollection = new List<int> { 4, 5, 6, 7, 8 };
            var exceptResult = firstCollection.Except(secondCollection);

            Console.WriteLine("Elements in the first collection but not in the second collection:");
            foreach (var item in exceptResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
