namespace sess03_programming_constructs_arrays
{
    /// <summary>
    /// Program to demonstrate the if...else selection construct to demonstrate a message
    /// on the phone's battery status.
    /// </summary>
    public class IfElseBatteryStatus
    {
        static void Main(string[] args)
        {
            // Prompt the user for the percentage charge remaining in their battery
            Console.WriteLine("Please enter the percentage charge left in your phone's battery:");
            uint remainingCharge = Convert.ToUInt32(Console.ReadLine());

            if (remainingCharge > 20)
            {
                Console.WriteLine($"At {remainingCharge}%, your battery is OK 🆗");
            }
            else
            {
                Console.WriteLine($"At {remainingCharge}%, please recharge your battery 🔋");
            }
        }
    }
}