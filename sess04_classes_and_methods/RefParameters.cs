namespace sess04_classes_and_methods
{
    /// <summary>
    ///  Program to demonstrate passing parameters by reference using the 'ref' keyword.
    /// </summary>
    public class RefParameters
    {
        static void Calculate(ref int num1, ref int num2)
        {
            // Reduce the value of num1 by half
            num1 /= 2;
            // Double the value of num2
            num2 *= 2;
        }

        static void Main()
        {
            // Prompt the user for the value of num1
            Console.WriteLine("Please enter a number and I'll halve it for you ->");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number and I'll double it for you ->");
            int num2 = int.Parse(Console.ReadLine());

            // Display the values of num1 and num2 before method call
            Console.WriteLine($"The values of 'num1' and  'num2' before method invocation are:" +
                              $"\n{num1}, and {num2}.");
            // Invoke the 'Calculate' method
            Calculate(ref num1, ref num2);
            // Display the values of num1 and num2 after method call
            Console.WriteLine($"The values of 'num1' and  'num2' after method invocation are:" +
                              $"\n{num1}, and {num2}.");
        }
    }
}