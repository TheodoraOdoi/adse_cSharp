namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// The ScaleneTriangle class derives from the Triangle class. It represents a scalene triangle
    /// where all the 3 sides have different length. Ot provides methods to calculate its area and perimeter
    /// </summary>
    public class ScaleneTriangle : Triangle, I2DShape
    {
        // Fields
        private byte sideA;
        private byte sideB;
        private byte sideC;

        /// <summary>
        /// Instantiate a scalene triangle with all its side set to '0' (zero)
        /// </summary>
        private ScaleneTriangle()
        {
            this.sideA = 0;
            this.sideB = 0;
            this.sideC = 0;
        }

        /// <summary>
        /// Instantiate a scalene triangle with all its dimensions specified as parameters
        /// </summary>
        /// <param name="a">Dimensions of the first side of the scalene triangle</param>
        /// <param name="b">Dimensions of the second side of the scalene triangle</param>
        /// <param name="c">Dimensions of the third side of the scalene triangle</param>
        public ScaleneTriangle(byte a, byte b, byte c)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Side length should be positive");
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("The sum of the lengths of any two sides must be greater than the third side");
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }

        public override float CalculateArea()
        {
            // Calculate the area of the scalene triangle using Heron's formula
            float semiPerimeter = CalcPerimeter() / 2;
            return (float)Math.Sqrt(semiPerimeter * (semiPerimeter - this.sideA) * (semiPerimeter - this.sideB) * (semiPerimeter - this.sideC));
        }

        public virtual float CalcPerimeter()
        {
            return this.sideA + this.sideB + this.sideC;
        }

        public float CalcCircumference(int radius)
        {
            return 0.0f;
        }

        public override string ToString()
        {
            return $"Scalene Triangle's Dimensions" +
                $"\n" + new string('-', 50) +
                $"\nSide1: {this.sideA}" +
                $"\nSide2: {this.sideB}" +
                $"\nSide3: {this.sideC}" +
                $"\nArea: {this.CalculateArea()}" +
                $"\nPerimeter: {this.CalcPerimeter()}" +
                $"\n" + new string('-', 50);
        }
    }
}
