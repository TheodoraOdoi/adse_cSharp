namespace sess03_programming_constructs_arrays
{
    public class IfElseIfTimeGreeting
    {
        static void Main(string[] args)
        {
            // Variable to hold the user's name
            string? name = "user name";
            // Get the current hour from the system
            // uint currHour = DateTime.Now.Hour;

            // Prompt the user for their name and hour of the day
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the hour of the day (0 - 23): ");
            uint hour = Convert.ToUInt32(Console.ReadLine());

            // Greet the user base on the hour of the day
            if (hour >= 0 && hour < 12)
                Console.WriteLine($"Good morning {name}");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine($"Good afternoon {name}");
            else if (hour >= 18 && hour < 22)
                Console.WriteLine($"Good evening {name}");
            else
                Console.WriteLine($"Good night {name}");
        }
    }
}