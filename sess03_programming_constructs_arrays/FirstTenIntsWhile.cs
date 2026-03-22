namespace sess03_programming_constructs_arrays;
/// <summary>
/// Program to display the first ten integers using a while loop.
/// </summary>
public class FirstTenIntsWhile
{
    static void Main(string[] args)
    {
        uint n = 1;
        while (n <= 10)
        {
            Console.WriteLine(n);
            n++;
        }
    }
}