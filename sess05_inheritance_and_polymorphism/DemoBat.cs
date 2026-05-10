namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// Program to demonstrate inheritance and object instantiation.
    /// </summary>
    public class DemoBat: Bat
    {
        static void Main(string[] args)
        {
            DemoBat batman = new DemoBat();

            // Set the properties for the Bat from various base classes
            batman.food = "Insects or fruit"; // From the Animal base class
            batman.activity = "Bats are nocturnal"; // From the Animal base class
            //batman.activity = :Batman rounds up criminals like Joker & Harley Quinn in Gotham city."
            batman.habitat = "Batcave in Gotham City"; // From the Mammal class

            // Display the details of the DemoBat instance
            Console.WriteLine("batman");
        }

        private void DisplayBatDetails()
        {
            Console.WriteLine($"Details of the bat" +
                              $"\n" + new string('-', 50));
            this.Eat(food);
            Console.WriteLine(
                $"Number of wings: {Wings}" +
                $"\nNumber of legs: {Legs}" +
                $"\nNumber of ears: {Ears}");
            Console.WriteLine("Reproduction: ");
            MultiplyMammal("\nBat");
            Console.WriteLine("Behaviour: ");
            DisplayBatBehaviour();
            Console.WriteLine($"\n" + new string('-', 50));
        }
    }
}
