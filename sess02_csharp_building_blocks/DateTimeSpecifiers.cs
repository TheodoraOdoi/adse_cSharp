namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Program to demonstrate C#'s various date and time format specifiers
    /// </summary>
    public class DateTimeSpecifiers
    {
        static void Main(string[] args)
        {
            // Variable to hold the current date and time
            DateTime currDateTime = DateTime.Now;

            // Standard date and time format specifiers
            Console.WriteLine("C# Standard Date & Time Format Specifiers");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Short date (d): {currDateTime:d}");
            Console.WriteLine($"Long date (D): {currDateTime:D}");
            Console.WriteLine($"Full date (F): {currDateTime:F}");
            Console.WriteLine($"General date (G): {currDateTime:G}");
            Console.WriteLine($"Short time (t): {currDateTime:t}");
            Console.WriteLine($"Long time (T): {currDateTime:T}");
            Console.WriteLine($"RFC1123 (r): {currDateTime:r}");
            Console.WriteLine($"Sortable (s): {currDateTime:s}");
            Console.WriteLine($"Universal sortable (u): {currDateTime:u}");
            Console.WriteLine($"Day of the month (M): {currDateTime:M}");
            Console.WriteLine($"Month of the year (Y): {currDateTime:Y}");
            Console.WriteLine(new string('-', 70));

            // Custom date and time format specifiers
            Console.WriteLine("\nC# Custom Date & Time Format Specifiers");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Custom date (yyyy/MM/dd): {currDateTime:yyyy/MM/dd}");
            Console.WriteLine("Custom date (yyyy/MM/dd): " + currDateTime.ToString("yyyy/MM/dd}"));
            Console.WriteLine($"Custom time with am/pm (hh:mm:ss tt): {currDateTime:hh:mm:ss tt}");
            Console.WriteLine($"Custom date with day of the week (dddd, MMM, dd, yyyy): {currDateTime:dddd, MMM, dd, yyyy}");
            Console.WriteLine($"Custom time in 24-hour format (HH:mm:ss ): {currDateTime:HH:mm:ss}");
            Console.WriteLine($"Custom time in 24-hour format with milliseconds (HH:mm:ss.fff ): {currDateTime:HH:mm:ss.fff}");
            Console.WriteLine($"Custom date (day of the week & the year) (ddd,yyyy): {currDateTime:ddd,yyyy}");
            Console.WriteLine($"Custom date and time:\nDATE: (yyyy-MM-dd) {currDateTime:yyyy-MM-dd}\nTIME: (HH:mm:ss.fff ){currDateTime:HH:mm:ss.fff}");
            Console.WriteLine($"Custom time in 24-hour format with time zone (HH:mm:ss zzz): {currDateTime:HH:mm:ss zzz}");
            Console.WriteLine(new string('-', 70));
        }
    }
}