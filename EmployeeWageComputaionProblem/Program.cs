namespace EmployeeWageComputaionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.DailyWage();
            Console.WriteLine("Welcome to Employee Wage Computation.");
            Employee.ComputeEmployeeWage("Relience", 20, 20, 100);
            Employee.ComputeEmployeeWage("Nike", 2000, 22, 176);

        }
    }
}

