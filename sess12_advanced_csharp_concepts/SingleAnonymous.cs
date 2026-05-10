namespace sess12_advanced_csharp_concepts
{
    /// <summary>
    /// Program to demonstrate assigning a single anonymous method to a delegate.
    /// </summary>
    public class SingleAnonymous
    {
        // Declare the deligate inside the class
        delegate void Display(string message, int num);

        static void Main()
        {
            // Instantiate the Display delegate and assign it an anonymous inline method
            Display display = delegate (string message, int num)
            {
                Console.WriteLine(message, num);
            };

            // Call/Invoke the Display delegate object
            display("Missing you x{0}!!!", 10);
        }
    }
}
