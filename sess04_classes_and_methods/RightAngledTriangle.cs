namespace sess04_classes_and_methods
{
    /// <summary>
    /// This class is used to create a Right-Angled Triangle objects.
    /// </summary>
    public class RightAngledTriangle
    {
        // Private instance variables
        private byte height;
        private byte @base;
        private byte hypotenuse;

        /// <summary>
        /// Create a Right-Angled Triangle & initialise all its sides to 0.
        /// </summary>
        public RightAngledTriangle()
        {
            this.height = 0;
            this.@base = 0;
            this.hypotenuse = 0;
        }

        /// <summary>
        /// Creates a Right-Angled Triangle with the height & base passed in as parameters.
        /// The hypotenuse is calculated using the Pythagorean Theorem.
        /// </summary>
        /// <param name="height">The triangle's height</param>
        /// <param name="base">The triangle's base</param>
        public RightAngledTriangle(byte height, byte @base)
        {
            this.height = height;
            this.@base = @base;
            this.hypotenuse = (byte)(Math.Sqrt(height * height + @base * @base));
            //this.hypotenuse = (byte)(Math.Sqrt(Math.Pow(height, 2) + Math.Pow(@base, 2)));

        }

        private int CalculateArea()
        {
            return (int)(.5 * this.@base * this.height);
            // not the same as 1/2 * this.@base * this.height
        }

        private int CalculatePerimeter()
        {
            return this.@base + this.height * this.hypotenuse;
        }

        public override string ToString()
        {
            return $"Right-Angled Triangle's Dimensions" +
                $"\n{new string('-', 50)}" +
                $"\nBase: {this.@base}" +
                $"\nHeight: {this.height}" +
                $"\nHypotenuse: {this.hypotenuse}" +
                $"\nArea: {this.CalculateArea()}" +
                $"\nParimeter: {this.CalculatePerimeter}" +
                $"\n{new string('-', 50)}";
            ;
        }
    }
}
