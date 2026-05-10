namespace sess04_classes_and_methods
{
    /// <summary>
    /// Program to demonstrate passing values by reference using the 'out' keyword
    /// </summary>
    public class OutParameters
    {
        static void Depreciation(out int value)
        {
            value = 40000;
            Console.WriteLine($"Initial value of object: {value}");
            int dep = value * 20 / 100;
            int amount = value - dep;
            // Display the depreciation amount and final value of the object
            Console.WriteLine($"Depreciation amount: {dep}" +
                              $"\nReduced value after depreciation: {amount}");
        }

        static void Main()
        {
            int value;
            Depreciation(out value);
        }
    }
}