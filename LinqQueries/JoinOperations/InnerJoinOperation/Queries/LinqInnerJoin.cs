namespace LINQ.LinqQueries.JoinOperations.InnerJoinOperation.Queries
{
    internal class LinqInnerJoin
    {
        internal static void ExecuteInnerJoin()
        {
            Console.WriteLine("\n--------------------- Inner Join ---------------------");
            Console.WriteLine();
            Console.WriteLine("This is Language Integrated Query For - Inner Join \n\n");
            var employees = Utility.GenerateData.GetEmployees();
            var departments = Utility.GenerateData.GetDepartments();
            var innerJoinQuery = employees
                .Where(employee => employee?.Department != null)
                .Join(departments, employee => employee?.Department?.Id, department => department.Id, (employee, department) => new
                {
                    EmployeeName = employee.FirstName + " " + employee.LastName,
                    DepartmentName = department.ShortName
                }).ToList();

            foreach (var query in innerJoinQuery)
            {
                Console.WriteLine($"Employee Name: {query.EmployeeName}, Department Name: {query.DepartmentName}");
            }
        }
    }
}
