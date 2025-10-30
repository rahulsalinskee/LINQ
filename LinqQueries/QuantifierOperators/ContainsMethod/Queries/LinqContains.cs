using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.QuantifierOperators.ContainsMethod.Queries
{
    internal class LinqContains
    {
        internal static void ExecuteContains()
        {
            Console.WriteLine("\n--------------------- Contains Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Contains Method \n\n");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int numberToCheck = 3;
            // Using LINQ Contains method to check if the list contains the specified number
            bool containsNumber = numbers.Contains(numberToCheck);
            if (containsNumber)
            {
                Console.WriteLine($"The list contains the number {numberToCheck}.");
            }
            else
            {
                Console.WriteLine($"The list does not contain the number {numberToCheck}.");
            }

        }
    }
}
