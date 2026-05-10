using System.Buffers;
using System.Collections;

namespace sess09_delegate_events_collections
{
    /// <summary>
    /// Program to demonstrate working with SortedList class
    /// </summary>
    internal class SortedAccountList
    {
        static void Main(string[] args)
        {
            SortedList accountDetails = new SortedList();

            // Create a some dummy UserAccounts
            accountDetails.Add(10, new UserAccount("James56", "Passwords32$"));
            accountDetails.Add(8, new UserAccount("Nancho", "Kileleshwa3"));
            accountDetails.Add(17, new UserAccount("Light54", "Discreet89"));
            accountDetails.Add(4, new UserAccount("Ciku45", "PassmeIn"));
            accountDetails.Add(30, new UserAccount("Tesfai", "Hidden@1235"));
            accountDetails.Add(12, new UserAccount("James", "I_haveNOPass"));

            // Display they Key from the sorted list
            Console.WriteLine($"keys in the account details collection are");
            foreach (int key in accountDetails.Keys)
            {
                Console.WriteLine(key);
            }

            // Display values ( each user account Details are: )
            Console.WriteLine($"The user account details are: ");
            foreach (UserAccount account in accountDetails.Values)
            {
                Console.WriteLine(account);
            }
        }
    }
}
