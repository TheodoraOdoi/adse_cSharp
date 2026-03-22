namespace sess03_programming_constructs_arrays
{
    /// <summary>
    /// Program that uses nested selection/decision construct to determing whether or not to
    /// accept goods delivered to a company and the department they are to be dispatched to.
    /// </summary>
    public class NestedDecisionGoodDispatch
    {
        static void Main(string[] args)
        {
            // Variables to be used in the program
            bool goodsOK = false;
            string? department = "Marketing";

            // prompt the user for the condition of the delivered goods
            Console.WriteLine("Are the good damaged?\n'Y' or 'y' for 'yes' or" +
                " 'N' or 'n' for 'No' ->");
            char goodsStatus = Console.ReadKey().KeyChar;

            if (goodsStatus == 'N' || goodsStatus == 'n')
                goodsOK = true;

            // Make a decision based on the status of the delivered goods
            if (!goodsOK)
                Console.WriteLine($"\nGoods are damaged and should be returned to the manufacturer");
            else
            {
                // Prompt the user for the department the goods are to be sent/dispatched to
                Console.WriteLine("\nWhich department should the good be dispatched to?");
                department = Console.ReadLine().ToLower();
                switch (department)
                {
                    case "sales":
                        Console.WriteLine("Goods are OK and dispatched to the Sales department");
                        break;
                    case "marketing":
                        Console.WriteLine("Goods are OK and dispatched to the Marketing department");
                        break;
                    case "it":
                        Console.WriteLine("Goods are OK and dispatched to the IT department");
                        break;
                    case "accounts":
                        Console.WriteLine("Goods are OK and dispatched to the Accounts department");
                        break;
                    default:
                        Console.WriteLine("Goods are OK. Kindly confirm the department they " +
                            "should be dispatched to!");
                        break;
                }
            }
        }
    }
}