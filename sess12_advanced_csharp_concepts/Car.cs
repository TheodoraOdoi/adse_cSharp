namespace sess12_advanced_csharp_concepts
{
    /// <summary>
    /// Represents a car with details such as make, model, units sold & price.
    /// </summary>
    public class Car
    {
        // Car properties
        /// <summary>
        /// Gets or Sets the make of the car (eg, "Toyota", "Ford", "Mazda").
        /// </summary>
        public string Make { get; set; }
        /// <summary>
        /// Gets or Sets the model of the car (eg, "Camry", "Mustang", "CX-5").
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Gets or Sets the nymber of units sold for this car model.
        /// </summary>
        public uint UnitsSold { get; set; }
        /// <summary>
        /// Gets or Sets the price of the car.
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Initialises a new instance of the <see cref="Car"/> with default values.
        /// </summary>
        public Car()
        {
            this.Make = string.Empty;
            this.Model = string.Empty;
            this.UnitsSold = 0;
            this.Price = 0.0f;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Car"/> with the specified make, model & units sold.
        /// </summary>
        /// <param name="make">The make of the car.</param>
        /// <param name="model">The model of the car.</param>
        /// <param name="unitsSold">The number of units sold.</param>
        public Car(string make, string model, uint unitsSold)
        {
            this.Make = make;
            this.Model = model;
            this.UnitsSold = unitsSold;
            this.Price = 0.0f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="make">The make of the car.</param>
        /// <param name="model">The model of the car.</param>
        /// <param name="unitsSold">The number of units sold.</param>
        /// <param name="price">The price of the car.</param>
        public Car(string make, string model, uint unitsSold, float price)
        {
            this.Make = make;
            this.Model = model;
            this.UnitsSold = unitsSold;
            this.Price = price;
        }

        /// <summary>
        /// Returns a string representation of the car's details.
        /// </summary>
        /// <returns>A formatted string containing the car's make, model, units sold & price details if they are available.</returns>
        public override string ToString()
        {
            return $"Car Details" +
                $"\n" + new string('-', 60) +
                $"\nMake: {this.Make}" +
                $"\nModel: {this.Model}" +
                $"\nUnits Sold: {this.UnitsSold}" +
                (this.Price == 0.0f? "":$"\nPrice Kes.: {this.Price:0.00}") +
                $"\n" + new string('-', 60);
        }
    }
}
