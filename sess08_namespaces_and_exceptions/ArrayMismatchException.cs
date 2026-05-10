namespace sess08_namespaces_and_exceptions
{
    /// <summary>
    /// Program to demonstrate the ArrayMismatchException
    /// </summary>
    public class ArrayMismatchExceptionDemo
    {
        static void Main()
        {
            // Declare and initialise an array of student names
            string[] studentNames = { "Chandni", "Tesfai", "Abigail" };
            // Declare and initialise an array of the student's admission numbers
            uint[] admissionNums = { 1001, 1002, 1003 };
            // Declare and initialise an array of tuition fees
            double[] tuitionFee = { 5000.5, 4500.5, 5500.45 };
            // Declare and instantiate a float array of caution fee/money
            float[] cautionFee = new float[3];

            try
            {
                // Set the caution amount to the semester's tuition fee
                for (int n = 0; n < studentNames.Length; n++)
                    tuitionFee.CopyTo(cautionFee, n); // Will cause an exception (double to float)
            }
            catch (ArrayTypeMismatchException atme)
            {
                Console.WriteLine($"What went wrong:  {atme.Message}" +
                                  $"\nError: {atme}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"The exception" +
                                  $"{e.GetType().ToString().Replace("System.", "")} occurred.");
            }
        }

    }
}