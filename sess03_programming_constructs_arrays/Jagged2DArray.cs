namespace sess03_programming_constructs_arrays
{
    /// <summary>
    /// Program that demonstrates how to create and display the contents of a jagged array
    /// </summary>
    public class Jagged2DArray
    {
        static void Main(string[] args)
        {
            string[][] companies = new string[5][];
            {
                companies[0] = new string[] { "Intel", "AMD", "Apple" };// Computer/desktop/laptop processors
                companies[1] = new string[] { "Toyota", "Nissan", "Mercedes", "Mazda", "Ford", "Porsche" };// Cars
                companies[2] = new string[] { "Samsung", "HiSilicon", "Qualcom", "MediaTek" };// Mobile processors
                companies[3] = new string[] { "AMD", "Nvidia" };// Graphics cards
                companies[4] = new string[] { "Edmund", "Lavender", "Dennis", "Shamim", "Theodora", "Victor" };// Student companies

                // Display the contents of the jagged companies array
                for (int n = 0; n < companies.Length; n++)
                {
                    int a = 0;
                    Console.WriteLine($"List of companies in group {n + 1}: ");
                    do
                    {
                        Console.WriteLine($"{companies[n][a]} ");
                        a++;
                    }
                    while (a < companies[n].GetLength(0));
                    Console.WriteLine();
                }
            }
        }
    }
}