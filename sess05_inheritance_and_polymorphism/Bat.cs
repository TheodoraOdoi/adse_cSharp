namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    ///  The bat class derives from the Mammal class & will be used gto create Bat object/Instances
    /// </summary>
    public class Bat: Mammal
    {
        // Instance constance field
        protected const byte Wings = 2;
        protected const byte Legs = 2;
        protected const byte Ears = 2;

        public override void Eat(string diet)
        {
            Console.WriteLine($"{this.GetType().Name} eats {diet}");
            Console.WriteLine($"The bat eats: {diet}");
        }

        public void DisplayBatBehaviour()
        {
            Console.WriteLine($"\nThe bat flies");
        }
    }
}
