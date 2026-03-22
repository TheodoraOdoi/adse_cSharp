namespace sess03_programming_constructs_arrays
{
    /// <summary>
    /// Program to prevent division by zero '0' using the if construct
    /// </summary>
    public class IfCheckDenominator
    {
        static void Main(string[] args)
        {
            // Variables to be used in the program
            uint numerator, denominator, quotient;

            // Prompt the user for a numerator
            Console.WriteLine("Please enter a numerator to be used in division: ");
            numerator = Convert.ToUInt32(Console.ReadLine());
        UserPrompt: // Label that will be used in a goto statement

            // Prompt the user for a denominator
            Console.WriteLine("Please enter a denominator to be used in division: ");
            denominator = Convert.ToUInt32(Console.ReadLine());

            // Check if the user has entered zero '0'  as the denominator
            if (denominator == 0)
            {
                Console.WriteLine("Please enter a non-zero '0' value as division by zero " +
                    "will cause errors!!");
                goto UserPrompt;
            }

            quotient = numerator / denominator;
            // Display the result
            Console.WriteLine("{0} {1} {2} = {3}", numerator, '\u00f7', denominator, quotient);
        }
    }
}