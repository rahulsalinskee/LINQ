using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.QuantifierOperators.AnyMethod.Queries
{
    internal class LinqAny
    {
        internal static void ExecuteAny()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--------------------- Any Method ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Any Method \n\n");
            List<int> numbers = new List<int> { 1, 3, 5, 7, 9 };
            // Using LINQ Any method to check if there are any even numbers in the list
            bool hasEvenNumbers = numbers.Any(num => num % 2 == 0);
            if (hasEvenNumbers)
            {
                Console.WriteLine("The list contains even numbers.");
            }
            else
            {
                Console.WriteLine("The list does not contain any even numbers.");
            }
        }
    }
}
