namespace sess04_classes_and_methods
{
    /// <summary>
    /// Program to demonstrate the static & overloaded methods in the SimpleMath class.
    /// </summary>
    public class DemoSimpleMath
    {
        static void Main(string[] args)
        {
            // Variables to be used in the program
            int firstNum, secondNum;
            long total;
            int[] scores = { 45, 35, 55, 65, 85, 45 };

            // Prompt the user for the numbers to be added
            Console.WriteLine("Please enter the first number to be added ->");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number to be added ->");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third number to be added ->");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            // Calculate & display the sum of the above variables
            total = SimpleMath.AddNums(firstNum, secondNum);
            Console.WriteLine($"The sum of {firstNum} + {secondNum} = {total}");
            Console.WriteLine($"The sum of {firstNum} + {secondNum} + {thirdNum} = " +
                $"{SimpleMath.AddNums(firstNum, secondNum, thirdNum)}");
            Console.WriteLine($"The sum of ");
            for (uint n = 0; n < scores.Length; n++)
            {
                if(n < (scores.Length - 1)) {
                    Console.Write($"{scores[n]} ");}
                else
                    Console.Write($" and {scores[n]}, ");
               // Console.WriteLine(n < (scores.Length - 1)? $"{scores[n]}, ": $"and {scores[n]},");
            }
            Console.WriteLine($"is {SimpleMath.AddNums(scores)}");
            Console.WriteLine();

            // Demonstrate passing method arguments by named parameters
            Console.WriteLine("Passing values by parameter name");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"The sum of {firstNum} + {secondNum} + {thirdNum} = " +
                $"{SimpleMath.AddNums(num3: thirdNum, num2: secondNum, num1: firstNum)}");
            Console.WriteLine(new string('-', 50));
        }
    }
}
