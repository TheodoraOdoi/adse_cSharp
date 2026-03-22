namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// This program demonstrates checked code to handle overflows
    /// </summary>
    public class CheckedCode
    {
        static void Main(string[] args)
        {
            int maxValue = int.MaxValue;

            // Checked code block: overflow will throw an exception
            try
            {
                checked
                {
                    int result = maxValue + 1;
                    Console.WriteLine($"Result of adding 1 to {maxValue} is {result}.");
                }
            }
            catch (OverflowException ofe)
            {
                Console.WriteLine($"Overflow exception: \n{ofe.Message}");
                throw;
            }
        }
    }
}