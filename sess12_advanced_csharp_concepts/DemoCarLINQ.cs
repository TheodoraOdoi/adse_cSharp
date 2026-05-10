namespace sess12_advanced_csharp_concepts
{
    /// <summary>
    /// This program demonstrates the use of Language Integrated Query(LINQ) to query data from an in-memory list.
    /// </summary>
    public class DemoCarLINQ
    {
        public static void Main()
        {
            // Declare & Instantiate several car objects
            Car car1 = new Car("VW", "Golf", 270952);

            Car car2 = new Car("Opel", "Astra", 56079);

            Car car3 = new Car("Audi", "A4", 52493);

            Car car4 = new Car("Ford", "Focus", 51667);

            Car car5 = new Car("Nissan", "Fairlady", 95243);

            Car car6 = new Car("Mazda", "RX-8", 42125);

            Car car7 = new Car("VW", "Passat", 97586);

            Car car8 = new Car("VW", "Polo", 67549);

            Car car9 = new Car("Ford", "Shelby-500GT", 28000);

            // Create a list of cars & add the above cars
            List<Car> cars = new List<Car>
            {
                car1,
                car2,
                car3,
                car4,
                car5,
                car6,
                car7,
                car8,
                car9
            };

            // List the Volkswagen ('VW') cars
            var vwCars = from car in cars
                         where car.Make.Contains("VW")
                         select car;
            Console.WriteLine("Volks Car Details");
            foreach (Car vwCar in vwCars)
                Console.WriteLine(vwCar);

            //List the cars with more than 50,000 units sold
            var carWith50KSales = from car in cars
                                  where car.UnitsSold > 50000
                                  orderby car.UnitsSold descending
                                  select car;
            Console.WriteLine("\nCars with over 50, 000 units sold");
            foreach (Car carSold in carWith50KSales)
                Console.WriteLine(carSold);

            // TODO: Use LINQ to get the total of all units sold
            var totalUnitsSold = cars.Sum(car => car.UnitsSold);

            Console.WriteLine($"\nTotal Units Sold: {totalUnitsSold:N0}"); 
        }
    }
}
