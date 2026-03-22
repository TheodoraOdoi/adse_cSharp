namespace sess03_programming_constructs_arrays
{
    /// <summary>
    /// Program to demonstrate how to create a rectangular 2-d array
    /// </summary>
    public class Rectangular2DArray
    {
        static void Main(string[] args)
        {
            uint[,] dimension = new uint[4, 5];
            uint numOne = 1; // Variable for display purposes
            for (int n = 0; n < dimension.GetLength(0); n++) // for the rows
            {
                for (int a = 0; a < dimension.GetLength(1); a++) // for the columns
                {
                    // Populate the array elements with values
                    dimension[n, a] = numOne;
                    numOne++;
                }
            }

            // Display the values in the 2-d rectangular array
            for (int n = 0; n < 4; n++)
            {
                for (int a = 0; a < dimension.GetLength(1); a++)
                    Console.Write($"{dimension[n, a]:0#} ");
                Console.WriteLine();
            }
        }
    }
}