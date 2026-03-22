namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Program to demonstrate how to read in values from the user and convert them to 
    /// their respective value types.
    /// </summary>
    public class ReadUserDetails
    {
        static void Main(string[] args)
        {
            // Variables to be used in the program
            string username;
            int age;
            double salary;

            // Prompt the user for their name
            Console.WriteLine("Please enter your name -> ");
            username = Console.ReadLine();

            // Prompt the user for their age
            Console.WriteLine("Please enter your age -> ");
            age = Convert.ToInt32(Console.ReadLine()); // Read in the user's age and convert it to a 32-bit integer.

            // Prompt the user for their salary
            Console.WriteLine("Please enter your salary -> ");
            salary = Convert.ToDouble(Console.ReadLine());

            // Display the user's details
            Console.WriteLine("\nUser Details:");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Name: {username}\nAge: {age}\nSalary: {salary}");
            Console.WriteLine(new string('-', 70));
        }
    }
}