using LINQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LinqQueries.PartitioningOperators.PaginationFunctionality
{
    internal class Pagination
    {
        internal static void ExecutePagination()
        {
            Console.WriteLine("\n--------------------- Pagination Functionality ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Pagination Functionality \n\n");

            do
            {
                Console.Write("\nEnter Page Number: ");

                int pageNumber, totalPagePerView;

                pageNumber = int.TryParse(Console.ReadLine(), out pageNumber) ? pageNumber : 1;

                Console.Write("\nTotal Page Per View: ");
                totalPagePerView = int.TryParse(Console.ReadLine(), out totalPagePerView) ? totalPagePerView : 1;

                var employees = GenerateData.GetEmployees();

                /* Pagination Logic */
                var filteredEmployees = employees.Skip((pageNumber - 1) * totalPagePerView).Take(totalPagePerView);

                Console.WriteLine($"Page Number: {pageNumber}, Page Size: {totalPagePerView}");
                foreach (var filteredEmployee in filteredEmployees)
                {
                    Console.WriteLine("\n" +
                        "ID: " + filteredEmployee.Id + "\n" +
                        "First Name: " + filteredEmployee.FirstName + "\n" +
                        "Last Name: " + filteredEmployee.LastName + "\n");
                }
            } while (true);
        }
    }
}
