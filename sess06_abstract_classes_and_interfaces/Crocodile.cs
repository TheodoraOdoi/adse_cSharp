namespace sess06_abstract_classes_and_interfaces
{
    public class Crocodile : IMarineAnimal, ITerrestialAnimal
    {
        string ITerrestialAnimal.Eat()
        {
            return "Crocodile eats land animals like gnu & zebras.";
        }

        string IMarineAnimal.Eat()
        {
            return "Crocodile eats fish and other marine animals.";
        }

        public string EatTerrestial()
        {
            ITerrestialAnimal terrestialAnimal = this;
            return terrestialAnimal.Eat();
        }

        public string EatMarine()
        {
            IMarineAnimal marineAnimal = this;
            return marineAnimal.Eat();
        }

        static void Main(string[] args)
        {
            // Declare and instantiate a Crocodile object
            Crocodile crocodile = new Crocodile();

            // Display the crocodile's diet from the IMarine interface
            Console.WriteLine($"From IMarine: {crocodile.EatMarine()}");

            // Display the crocodile's diet from the ITerrestial interface
            Console.WriteLine($"From ITerrestial: {crocodile.EatTerrestial()}");
        }
    }
}
