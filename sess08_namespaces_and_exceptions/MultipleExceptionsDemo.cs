namespace sess08_namespaces_and_exceptions
{
    /// <summary>
    /// Program demonstrating how to handle multiple exceptions.
    /// </summary>
    public class MultipleExceptionsDemo
    {
        /// <summary>
        /// Method to read in a string from the user via the console and convert it to a byte.
        /// </summary>
        /// <returns>byte value of the input string</returns>
        /// <exception cref="FormatException">Thrown when converting the string to a byte fails.</exception>
        private static byte ReadByteFromConsole()
        {
            string? input = Console.ReadLine()?.Trim();
            if (string.IsNullOrWhiteSpace(input))
                throw new FormatException("Sorry, no input provided.");
            return byte.Parse(input); // Parse method will throw FormatExcepction for non-numeric values
                                      // and overflow exception for values outside byte.MaxValue & byte.MinValue
        }
        static void Main(string[] args)
        {
            byte numerator, denominator;
            int quotient;
            try
            {
                // Prompt the user for the numerator and denominator
                Console.WriteLine("Please enter the numerator ( 0 - 255): ");
                numerator = ReadByteFromConsole();

                Console.WriteLine("Please enter the denominator ( 0 - 255): ");
                denominator = ReadByteFromConsole();

                quotient = numerator / denominator; // Will throw DivideByZeroException when denom. is 0

                // Division results
                Console.WriteLine($"\n{numerator} ÷ {denominator} = {quotient}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"\n❌FormatException: Sorry input provided was not a number." +
                                  $"\nPlease use digits e.g. 8 or 5." +
                                  $"\nException Details: {fe.Message}");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine($"\n❌OverflowException: Sorry number provided is less than 0 or greater than 255." +
                                  $"\nPlease use values between (0 - 255)." +
                                  $"\nException Details: {oe.Message}");
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine($"\n❌DivideByZeroException: Sorry, cannot divide by zero." +
                                  $"\nPlease use a non-zero denominator e.g. 8 or 5." +
                                  $"\nException Details: {dbze.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n❌Unexpected Exception: {e.GetType().Name}." +
                                  $"\nMessage : {e.Message}");
            }
        }
    }
}