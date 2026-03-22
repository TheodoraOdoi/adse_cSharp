namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Program to demonstrate C#'s numeric format specifiers
    /// </summary>
    public class NumericSpecifiers
    {
        static void Main(string[] args)
        {
            // Variables to hold sample numbers to be used in the program
            int intValue = 123457;
            double doubleValue = 321457.789;
            decimal decValue = 123457.987m;

            //Currency format specifier
            Console.WriteLine("Currency Format (C):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("C"));
            Console.WriteLine($"{intValue:c}");
            Console.WriteLine(doubleValue.ToString("C"));
            Console.WriteLine($"{doubleValue:c}");
            Console.WriteLine(decValue.ToString("C"));
            Console.WriteLine($"{decValue:c}");
            Console.WriteLine(new string('-', 70));

            //Decimal format specifier
            Console.WriteLine("\nDecimal Format (D):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("D"));
            Console.WriteLine($"{intValue:d}");
            Console.WriteLine($"{123:d7}"); // Padded with leading zeros
            Console.WriteLine(123.ToString("D7"));
            Console.WriteLine(new string('-', 70));

            //Exponential/Scientific format specifier
            Console.WriteLine("\nExponential/Scientific Format (E):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:E}");
            Console.WriteLine($"{intValue:e}");
            Console.WriteLine(new string('-', 70));

            //Fixed-point format specifier
            Console.WriteLine("\nFixed-point Format (F):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:f}"); // default is correct to 2 d.p. 
            Console.WriteLine($"{doubleValue:f4}"); // Correct to 4 d.p.
            Console.WriteLine(new string('-', 70));

            //General format specifier
            Console.WriteLine("\nGeneral Format (G):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:G}");
            Console.WriteLine($"{decValue:g}");
            Console.WriteLine(new string('-', 70));

            //Number format specifier
            Console.WriteLine("\nNumber Format (N):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(doubleValue.ToString("N"));
            Console.WriteLine($"{decValue:n}");
            Console.WriteLine(new string('-', 70));

            //Percentage format specifier
            Console.WriteLine("\nPercentage Format (P):");
            Console.WriteLine(new string('-', 70));
            double percentage = .85;
            Console.WriteLine(percentage.ToString("P"));
            Console.WriteLine($"{percentage:p}");
            Console.WriteLine(new string('-', 70));

            //Hexadecimal format specifier
            Console.WriteLine("\nHexadecimal Format (X):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("X"));
            // With padding
            Console.WriteLine("Hexadecimal with padding (X7)");
            Console.WriteLine($"{intValue:x7}");
            Console.WriteLine(new string('-', 70));

        }
    }
}