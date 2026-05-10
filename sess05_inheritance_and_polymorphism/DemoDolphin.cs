// TODO: Create a C# class with a main method called DemoDolphiin to demonstrate creating Dolphin objects
//and display its fields and behaviours from its various classes
namespace sess05_inheritance_and_polymorphism
{
    internal class DemoDolphin: Dolphin
    {
        static void Main(string[] args)
        {
            DemoDolphin dolphin = new DemoDolphin();

            // Set properties for the Dolphin from various base classes.
            dolphin.food = "Fish"; // From the Animal base class
            dolphin.activity = "Swimming"; // From the Animal base class
            dolphin.habitat = "Ocean"; // From the Mammal base class

            // Display the details of the DemoDolphin instance.
            Console.WriteLine("dolphin");
        }

        private void DisplayDolphinDetails()
        {
            Console.WriteLine($"Details of the dolphin" +
                              $"\n" + new string('-', 50));
            this.Eat(food);
            Console.WriteLine(
                $"Number of flippers: {Flippers}" +
                $"\nNumber of shout: {Shout}" +
                $"\nNumber of blowhole: {Blowhole}" +
                $"\nNumber of fins: {Fins}");
            Console.WriteLine("Reproduction: ");
            MultiplyMammal("\nDolphin");
            Console.WriteLine("Behaviour: ");
            DisplayDolphinBehaviour();
            Console.WriteLine($"\n" + new string('-', 50));
        }
    }
}
