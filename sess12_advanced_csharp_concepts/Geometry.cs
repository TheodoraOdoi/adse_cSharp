namespace sess12_advanced_csharp_concepts
{
    public abstract partial class Geometry
    {
        public virtual double CalcVolume(float side) 
        { 
            return 0.0; 
        }  
    }

    public class Cube: Geometry
    {
        public override float CalcArea(float side)
        {
            return (side * side) * 6; // return (float)(Math.Pow(side,2)*6;
        }

        // public override double CalcVolume(float side) {return Math.Pow(side, 3);}
        public override double CalcVolume(float side) => Math.Pow(side, 3);

        static void Main(string[] args)
        {
            // Prompt the user for the dimensions of the cube
            Console.WriteLine("Please enter the dimension/side of the Cube.");
            float side = float.Parse(Console.ReadLine());

            // Declare and instantiate a new cube
            Cube cube = new Cube();

            // Display the cube's dimensions
            Console.WriteLine($"Cube's Details" +
                $"\n" + new string('-', 60) +
                $"\nSide {side}" +
                $"\nSurface Area {cube.CalcArea(side):0.000} m'." +
                $"\nVolume {cube.CalcVolume(side)"0.000} m'." +
                $"\n" + new string('-', 60)
                );
        }
    }
}
