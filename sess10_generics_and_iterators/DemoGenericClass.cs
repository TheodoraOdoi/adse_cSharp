namespace sess10_generics_and_iterators
{
    /// <summary>
    /// Program to demonstrate how to work with a user-defined/custom generic class
    /// </summary>
    public class DemoGenericClass
    {
        static void Main(string[] args)
        {
            int n; // looping variable

            //Declare value and reference types using the custom generic class
            GenericClass<float> temps;
            GenericClass<string> series;//GenericClass<string> movies; GenericClass<string> series
            GenericClass<Person> people;

            int numOfItems;

            //Prompt the user for the number of temperatures they'd like to store
            Console.WriteLine("How many temperatures do you wish to store?");
            numOfItems = int.Parse(Console.ReadLine());
            //Instantiate the generic temperatures
            //temps = new GenericClass<float>(numOfItems);
            temps = new(numOfItems);

            //use a for loop to read in the temperatures from the user
            for (n = 0; n < numOfItems; n++)
            {
                Console.WriteLine($"Please enter the value for temperature {n + 1}:");
                temps.AddItem(float.Parse(Console.ReadLine()));
            }

            //Display the temperatures entered by the user
            Console.WriteLine(temps);

            //TODO 1: Prompt the user for the number of games/movies/series they'd like 
            //to store, read the in and display them
            Console.WriteLine("How many series would you like to store?");
            numOfItems = int.Parse(Console.ReadLine());
            //instantiate the generic class of persons
            series = new(numOfItems);
            // Read the details of the series
            for (n = 0; n < numOfItems; n++)
            {
                Console.WriteLine($"Please enter the name of series {n + 1}:");
                string title = Console.ReadLine();

                // Create a new series and add them to the list of series
                series.AddItem(title);
            }
            // Display the details for each person
                Console.WriteLine(series);
            

            // Prompt the user for the number of people they'd like to store
            Console.WriteLine("How many people would you like to store?");
            numOfItems = int.Parse(Console.ReadLine());
            //instantiate the generic class of persons
            people = new(numOfItems);
            //Read in the people details
            for (n = 0; n < numOfItems; n++)
            {
                Console.WriteLine($"Please enter the name of the person {n + 1}:");
                string name = Console.ReadLine();
                Console.WriteLine($"Please enter {name}'s birth date:");
                DateTime dob = DateTime.Parse(Console.ReadLine()); // for(n = 0; n < numOfItems; n++)
                Console.WriteLine($"Please enter {name}'s gender:");
                char gender = char.Parse(Console.ReadLine());
                Console.WriteLine($"Please enter {name}'s email:");
                string email= Console.ReadLine();
                Console.WriteLine($"Please enter {name}'s nationality:");
                string nationality = Console.ReadLine();

                //Create a new person and add them to the list of people
                people.AddItem(new Person(name, dob, gender, email, nationality));
            }

            //Display the details for each person
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
