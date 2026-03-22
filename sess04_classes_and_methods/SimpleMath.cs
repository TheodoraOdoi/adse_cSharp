namespace sess04_classes_and_methods
{
    /// <summary>
    /// This class demonstrates the use of static methods & method overloading
    /// </summary>
    public class SimpleMath
    {
        /// <summary>
        /// Adds two integers & returns their sum as a long value
        /// </summary>
        /// <param name="num1">First number to be used in the addition</param>
        /// <param name="num2">Second number to be used in the addition</param>
        /// <returns>The sum of the two integers passed in as parameters</returns>
        public static long AddNums(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Adds three integers & returns their sum as a long value
        /// </summary>
        /// <param name="num1">First number to be used in the addition</param>
        /// <param name="num2">Second number to be used in the addition</param>
        /// <param name="num3">Third number to be used in the addition</param>
        /// <returns>The sum of the two integers passed in as parameters</returns>
        public static long AddNums(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        /// <summary>
        /// Add the values in an array of integers & returns their sum.
        /// </summary>
        /// <param name="nums">An array of integers</param>
        /// <returns>The sum of the integer values in the array</returns>
        public static long AddNums(params int[] nums)
        {
            // long sum = 0;
            // foreach (int num in nums)
            // sum += num;
            // return sum;
            return nums.Sum();
        }
    }
}
