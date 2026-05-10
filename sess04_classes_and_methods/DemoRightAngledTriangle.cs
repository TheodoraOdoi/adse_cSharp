namespace sess04_classes_and_methods
{
    /// <summary>
    /// Program to demonstrate instantiating an object and calling/invoking its method(s)
    /// </summary>
    public class DemoRightAngledTriangle
    {
        static void Main()
        {
            // Prompt the user of the dimensions of the right-angled triangle
            Console.WriteLine("Please enter the base of the right-angled triangle:");
            byte @base = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of the right-angled triangle:");
            byte height = byte.Parse(Console.ReadLine());

            // Declare and instantiate a RightAngledTriangle object using the above dimensions
            RightAngledTriangle tr1 = new RightAngledTriangle(height, @base);

            // Invoke the triangle's 'ToString()' method to display its dimensions
            Console.WriteLine(tr1);
        }
    }
}  