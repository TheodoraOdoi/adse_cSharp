using sess04_classes_and_methods;
using sess07_properties_records_indexers;

namespace sess08_namespaces_and_exceptions
{
    /// <summary>
    /// Program to illustrate how to work with classes from different namespaces.
    /// </summary>
    public class DemoPersons
    {
        static void Main(string[] args)
        {
            SimplePerson buddy1 = new SimplePerson();
            // You can prompt the user for the values, but for now we'll hard-code them
            buddy1.SetNames("Yukti Velani");
            buddy1.SetGender("Female");
            buddy1.SetBirthDate(Convert.ToDateTime("20-08-1999"));
            buddy1.SetNationality("Indian");

            // Display buddy1's details
            Console.WriteLine(buddy1);

            SimplerPerson friend2 = new SimplerPerson();
            Console.WriteLine();// Extra line break
            friend2.Names = "Ruth Boaz";
            friend2.Gender = 'f';
            friend2.BirthDate = Convert.ToDateTime("25-03-2016");
            friend2.Nationality = "Israeli";

            // Display friend2's details
            Console.WriteLine(friend2);
        }
    }
}