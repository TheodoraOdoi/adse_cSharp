namespace sess03_programming_constructs_arrays;
/// <summary>
/// Program to compute the factorial of a number entered by the user using a for loop.
/// </summary>
public class ForFactorial
{
    static void Main(string[] args)
    {
        // Variables to be used in the program
        uint? userNum;
        ulong factorial = 1LU;

        // Prompt the user for a positive number whose factorial they'd like to know
        Console.WriteLine("Please enter a number and I'll tell you its factorial ->");
        userNum = uint.Parse(Console.ReadLine());

        for (uint n = 1; n <= userNum; factorial *= n++) ; // Compute the factorial using a for loop without a body

        // Display the factorial
        Console.WriteLine($"\nThe factorial of {userNum} is {factorial}");
    }
}