namespace sess03_programming_constructs_arrays;

/// <summary>
/// Program to display the name of each student in the class using a for...each loop
/// </summary>
public class ForEachNames
{
    static void Main(string[] args)
    {
        // Declare an array of student names
        string[] studentNames = { "Edmund", "Lavender", "Dennis", "Shamim", "Theodora", "Victor" };

        // Display the names of the students in class
        Console.WriteLine("The names of the students present in class today are:");
        uint n = 1;
        foreach (string name in studentNames)
            Console.WriteLine($"Student {n++:d2}: {name}");
    }
}