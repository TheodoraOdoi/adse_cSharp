namespace sess05_inheritance_and_polymorphism
{
    public class Dolphin: Mammal
    {
        // Instance constance field
        protected const byte Flippers = 2;
        protected const byte Shout = 1;
        protected const byte Blowhole = 1;
        protected const byte Fins = 5;

        public override void Eat(string diet)
        {
            Console.WriteLine($"{this.GetType().Name} eats {diet}");
            Console.WriteLine($"The dolphin eats: {diet}");
        }

        public void DisplayDolphinBehaviour()
        {
            Console.WriteLine($"\nThe dolphin swims");
        }
    }
}
