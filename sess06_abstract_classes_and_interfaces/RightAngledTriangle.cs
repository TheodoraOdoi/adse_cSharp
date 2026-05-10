namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// The RightAngledTriangle class derives from the Triangle class. It will be used to instantiate right-angled triangle
    /// objects
    /// </summary>
    public class RightAngledTriangle : Triangle, I2DShape
    {
        // Fields
        private byte height;
        private byte @base;
        private byte hypotenuse;

        public RightAngledTriangle()
        {
            this.height = 0;
            this.@base = 0;
            this.hypotenuse = 0;
        }

        public RightAngledTriangle(byte height, byte @base)
        {
            this.height = height;
            this.@base = @base;
            this.hypotenuse = (byte)(Math.Sqrt(height * height * @base * @base));
        }

        public override float CalculateArea()
        {
            return .5f * this.@base * this.height;
        }
        public float CalcPerimeter()
        {
            return this.height * this.@base * this.hypotenuse;
        }

        public float CalcCircumference(int radius)
        {
            return 0.0f;
        }

        public override string ToString()
        {
            return $"Right Angled Triangle's Dimensions" +
                $"\n" + new string('-', 50) +
                $"\nBase: {this.@base}" +
                $"\nHeight: {this.height}" +
                $"\nHypotenuse: {this.hypotenuse}" +
                $"\nArea: {this.CalculateArea()}" +
                $"\nPerimeter: {this.CalcPerimeter()}" +
                $"\n" + new string('-', 50);
        }


    }
}
