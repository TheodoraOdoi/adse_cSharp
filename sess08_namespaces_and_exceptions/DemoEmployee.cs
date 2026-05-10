using sess08_namespaces_and_exceptions.Salary;

namespace sess08_namespaces_and_exceptions
{
    /// <summary>
    /// Program to demonstrate namespaces from the same project and nested namespaces.
    /// </summary>
    public class DemoEmployee
    {
        static void Main(string[] args)
        {
            // Declare and instantiate an Employee object
            Employee emp1 = new Employee();
            // Prompt the user for the employee's details
            Console.WriteLine(@"Please enter the employee's name ->");
            emp1.Names = Console.ReadLine();
            Console.WriteLine($@"Please enter the {emp1.Names}'s employeeID:");
            emp1.EmpID = uint.Parse(Console.ReadLine());
            Console.WriteLine($@"Please enter the {emp1.Names}'s gender ->");
            emp1.Gender = char.Parse(Console.ReadLine());
            Console.WriteLine($@"Please enter the {emp1.Names}'s date of  birth:");
            emp1.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($@"Please enter the {emp1.Names}'s Nationality:");
            emp1.Nationality = Console.ReadLine();

            // Declare and instantiate a SalaryDetails object
            SalaryDetails empSalary = new SalaryDetails();
            Console.WriteLine($@"Please enter {emp1.Names}'s Salary Amount:");
            empSalary.EmployeeSalary = Convert.ToDouble(Console.ReadLine());

            // Display the employee's detail and their salary
            Console.WriteLine(emp1 + "" + empSalary);
        }
    }
}