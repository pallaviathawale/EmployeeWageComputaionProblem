namespace EmployeeWageComputaionProblem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.DailyWage();
            //Console.WriteLine("Welcome to Employee Wage Computation.");
            //Employee.ComputeEmployeeWage("Relience", 20, 20, 100);
            //Employee.ComputeEmployeeWage("Nike", 2000, 22, 176);

            EmployeeWage empwage = new EmployeeWage();

            empwage.addCompanies("Damart", 20, 15, 90);

            empwage.addCompanies("Relience", 45, 23, 150);

            empwage.EmpComputation();
        }
    }
}

