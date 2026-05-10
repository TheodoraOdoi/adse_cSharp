using System.Collections;

namespace sess09_delegate_events_collections
{
    public class ArrayListDemo
    {
        static void Main(string[] args)
        {
            // Declare and instantiate an ArrayList object/instance
            ArrayList fruitList = new ArrayList();

            // Display the initial capacity of the 'fruitlist' is: 
            Console.WriteLine($"The initial capacity of the 'fruitList is: {fruitList.Count}");

            fruitList.Add("Apple");
            fruitList.Add("Orange");
            fruitList.Add("Banana");
            fruitList.Add("Pineapple");
            fruitList.Add("Mango");
            fruitList.Add("Watermelon");
            fruitList.Add("Avocado");
            fruitList.Add("Kiwi Fruit");
            fruitList.Add("Grapes");
            fruitList.Add("Passion fruit");
            fruitList.Add("Blueberry");
            fruitList.Add("Strawberry");
            fruitList.Add("Papaya");
            fruitList.Add("Pomogranete");
            fruitList.Add("Guava");
            fruitList.Add("Pears");
            fruitList.Add("Cherry");
            fruitList.Add("Peach");
            fruitList.Add("Durian");
            fruitList.Add("Dragonfruit");

            // Display the original list of fruits
            Console.WriteLine($"The original fruitlist has {fruitList.Count} fruits, and they are as listed below");
            foreach (string fruit in fruitList)
            {
                Console.WriteLine(fruit);
            }

            // Insert a fruit before 'mango'
            fruitList.Insert(4, "Lemon");
            // Replace 'Kiwi fruit' with figs
            fruitList[8] = "Figs";

            // Display the modified and unsorted list of fruits
            Console.WriteLine($"The modified and unsorted 'fruitlist' has {fruitList.Count} fruits, and they are as follows");
            for (int n = 0; n < fruitList.Count; n++)
            {
                Console.WriteLine($"{(n + 1):00}. {fruitList[(int)n]}");
            }

            // Sort the 'fruitlist' in reverse lexigographical (descending) order
            fruitList.Sort(); // Sorts the fruits in Ascending order
            fruitList.Reverse(); // Reverse the sort (Effectively sorting in descending order)
            Console.WriteLine($"The list of fruits in reverse lexigographical (descending) order are:");
            for (int n = 0; n < fruitList.Count; n++)
            {
                Console.WriteLine($"{(n + 1):00}. {fruitList[(int)n]}");
            }
        }
    }
}
