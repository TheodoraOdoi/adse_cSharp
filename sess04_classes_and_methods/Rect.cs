namespace sess04_classes_and_methods
{
    /// <summary>
    /// The Rect class will be used to create Rectangle objects.
    /// </summary>
    public class Rect
    {
        //Fields
        private uint length;
        private uint width;

        public Rect()
        {
            this.length = 0;
            this.width = 0;
        }

        public Rect(uint length, uint width)
        {
            this.length = length;
            this.width = width;
        }

        public uint GetLength() { return this.length; }

        public void SetLength(uint length) { this.length = length; } 
        
        public uint GetWidth() { return this.width; }  
        
        public void SetWidth(uint width) { this.width = width; }

        public uint CalcArea() { return this.length * this.width; }

        public CalcPerimeter() { return 2 * (this.length + this.width); }   

        public override string? ToString()
        {
            return $"Rectangle's Dimensions" +
                $"\n---------------------------------------------" +
                $"\nLength: {this.GetLength()}" +
                $"\nWidth: {this.GetWidth()}" +
                $"\nArea: {this.CalcArea()}" +
                $"\nPerimeter: {this.CalcPerimeter()}" +
                $"\n---------------------------------------------"
                ;
        }
    }
}
