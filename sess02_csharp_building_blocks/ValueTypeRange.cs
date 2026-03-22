namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// C# Program to demonstrate the various value types and their ranges.
    /// </summary>
    public class ValueTypeRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# numeric types, their size in byte(s), min. and max. values");
            //Console.WriteLine(
            //"------------------------------------------------------------------------");
            Console.WriteLine(new string('-', 90));
            Console.WriteLine("Value type \t{0,-12} {1,25} {2,29}", "Size in Byte(s)", "Min. Value", "Max. Value");
            Console.WriteLine(new string('-', 90));
            Console.WriteLine(
                "sbyte:   {0,9} {1,38} {2,29}" +
                "\nbyte:    {3,9} {4,38} {5,29}" +
                "\nshort:   {6,9} {7,38} {8,29}" +
                "\nushort:  {9,9} {10,38} {11,29}" +
                "\nint:     {12,9} {13,38} {14,29}" +
                "\nuint:    {15,9} {16,38} {17,29}" +
                "\nlong:    {18,9} {19,38} {20,29}" +
                "\nulong:   {21,9} {22,38} {23,29}" +
                "\nfloat:   {24,9} {25,38} {26,29}" +
                "\ndouble:  {27,9} {28,38} {29,29}" +
                "\ndecimal: {30,9} {31,38} {32,29}" +
                "\n------------------------------------------------------------------------"
                , 1, sbyte.MinValue, sbyte.MaxValue
                , 1, byte.MinValue, byte.MaxValue
                , 2, short.MinValue, short.MaxValue
                , 2, ushort.MinValue, ushort.MaxValue
                , 4, int.MinValue, int.MaxValue
                , 4, uint.MinValue, uint.MaxValue
                , 8, long.MinValue, long.MaxValue
                , 8, ulong.MinValue, ulong.MaxValue
                , 4, float.MinValue, float.MaxValue
                , 8, double.MinValue, double.MaxValue
                , 16, decimal.MinValue, decimal.MaxValue
                );
            //Console.WriteLine(new string('-', 75));
        }
    }
}