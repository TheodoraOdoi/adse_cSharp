namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// This program demonstrates unchecked code to wrap overflows
    /// </summary>
    public class UncheckedCode
    {
        static void Main(string[] args)
        {
            int maxValue = int.MaxValue;

            unchecked // Unchecked block: overflow will wrap around instead of throwing an exception
            {
                int result = maxValue + 1;
                Console.WriteLine($"Unchecked result: {result}"); // Wraps around to int.minValue
            }
        }
    }
}