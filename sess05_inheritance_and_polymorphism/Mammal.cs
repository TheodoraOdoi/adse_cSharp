namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// The Mammal class derives from the Animal class & adds a new behaviour to it. 
    /// The Mammal class will be the base class for all derived mammals
    /// </summary>
    public abstract class Mammal: Animal
    {
        // Instance field
        protected string habitat;

        // Instance methods
        public abstract void Eat(string diet);

        public void MultiplyMammal(string name)
        {
            Console.WriteLine($"{name} gives birth to young ones.");
        }
    }
}
