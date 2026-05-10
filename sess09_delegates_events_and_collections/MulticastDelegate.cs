namespace sess09_delegate_events_collections
{
    /// <summary>
    /// program to demonstrate working with a Multicast delegate
    /// </summary>

    // Declare a delegate outside the class
    public delegate void MulticastCalc(int num1, int num2);
    public class MulticastDelegate
    {
        // class static methods
        static void AddNums(int num1, int num2) 
        { 
            Console.WriteLine($"{num1} + {num2} = {(num1 + num2)} ");
        }
        static void MultiplyNums(int num1, int num2) 
        { 
            Console.WriteLine($"{num1} * {num2} = {(num1 * num2)}"); 
        }
        static void SubtractNums(int num1, int num2) 
        { 
            Console.WriteLine($"{num1} - {num2} = {(num1 - num2)}"); 
        }
        static void GetRemainder(int num1, int num2) 
        { 
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}"); }

        static void DivideNums(int num1, int num2)
        {
            try
            {
                int results = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {results}");
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine($"Error:- ");
            }

        }

        static void Main(string[] args)
        {
            // Declare and instantiate the Multicast delegate
            MulticastCalc mathOperation = new MulticastCalc(AddNums); // pass the 1st method reference

            // Add the other class method references
            mathOperation += MultiplyNums;
            mathOperation += SubtractNums;
            mathOperation += GetRemainder;
            mathOperation += DivideNums;

            // Prompt the user for the numbers to be used for the calculation
            Console.WriteLine($"Please enter number 1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number 2");
            int num2 = int.Parse(Console.ReadLine());

            // Perform and display the results of the various arithmetic operations
            mathOperation(num1, num2);

            // Remove the multiply and remainder (modulus) operations
            Console.WriteLine($"Removing the multiplication and remainder method");
            mathOperation -= MultiplyNums;
            mathOperation -= GetRemainder;

            mathOperation(num1, num2);

        }
    }
}
