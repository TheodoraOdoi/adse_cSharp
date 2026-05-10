namespace sess12_advanced_csharp_concepts
{
    /// <summary>
    /// Program to demonstrate marking with multiple anonymous methods using delegates
    /// </summary>
    
    // Delegate declared outside the class
    delegate void Display();
    public class MultipleAnonymous
    {
        static void Main(string[] args)
        {
            // Instantiate the delegate with a single anonymous method
            Display disp = delegate 
            { 
                Console.WriteLine("Inside the first anonymous method.");
            };

            // Add the 2nd anonymous method to
        }
    }
}
