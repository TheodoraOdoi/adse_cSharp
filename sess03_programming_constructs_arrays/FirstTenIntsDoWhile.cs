namespace sess03_programming_constructs_arrays;

/// <summary>
/// Program to display the first ten integers using a do...while loop.
/// </summary>
public class FirstTenIntsDoWhile
{
    static void Main(string[] args)
    {
        uint n = 1;
        do
        {
            Console.WriteLine(n);
            n++;
        } while (n <= 10);
    }
}