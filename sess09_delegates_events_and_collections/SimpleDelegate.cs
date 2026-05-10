namespace sess09_delegate_events_collections
{
    /// <summary>
    /// program to demonstrate working with a simple method delegate
    /// </summary>

    // Declare a delegate outside the class
    public delegate int Calculation(int num1, int num2);

    public class SimpleDelegate
    {
        static int AddNums(int num1, int num2) 
        { 
            return num1 + num2; 
        }
        static int MultiplyNums(int num1, int num2) 
        { 
            return num1 * num2; 
        }
        static int SubtractNums(int num1, int num2) 
        { 
            return num1 - num2; 
        }

        static void Main(string[] args)
        {
            // Decalare and initialize values to be used in the program
            int val1 = 5, val2 = 6;

            // Declare delegate for the class (static) methods
            Calculation addDelegate, prodDelegate, subDelegate;

            // Instantiate the above delegate objects
            addDelegate = new Calculation(AddNums);
            prodDelegate = new Calculation(MultiplyNums);
            subDelegate = new Calculation(SubtractNums);

            // Invoke the respective methods using their delegates
            Console.WriteLine($"Sum of {val1} + {val2} = {addDelegate(val1, val2)}");
            Console.WriteLine($"Product of {val1} × {val2} = {prodDelegate(val1, val2)}");
            Console.WriteLine($"Difference of {val1} - {val2} = {subDelegate(val1, val2)}");


        }
    }
}
