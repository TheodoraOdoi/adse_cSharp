namespace sess07_properties_records_indexers
{
    /// <summary>
    /// Represents a person with basic details such as Names, BirthDate, Gender(binary) and Nationality.
    /// </summary>
    public class SimplerPerson
    {
        // Person's properties

        /// <summary>
        /// Gets or sets the person's names
        /// </summary>
        public string Names { get; set; }

        /// <summary>
        /// Gets or sets the person's birthdate
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the person's gender using 'M' or 'm' for Male and 'F' or 'f' for female
        /// </summary>
        public char Gender { get; set; }
        /// <summary>
        /// Gets or sets the person's nationality
        /// </summary>
        public string Nationality { get; set; }

        // Constructors

        /// <summary>
        /// Initialises a new instance/object of the <see cref="SimplerPerson"/> class with default values
        /// </summary>
        public SimplerPerson()
        {
            this.Names = "";
            this.BirthDate = DateTime.MinValue;
            this.Gender = 'M';
            this.Nationality = string.Empty;
        }

        /// <summary>
        /// Initialises a new instance/object of the <see cref="SimplerPerson"/> class with specified values
        /// </summary>
        /// <param name="names">The person's name</param>
        /// <param name="birthDate">The person's birthdate</param>
        /// <param name="gender">The person's binary gender</param>
        /// <param name="nationality">The person's nationality</param>
        public SimplerPerson(string names, DateTime birthDate, char gender, string nationality)
        {
            this.Names = names;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Nationality = nationality;
        }

        /// <summary>
        /// Returns a formatted string representation of the person's details.
        /// </summary>
        /// <returns>
        /// A human-readable string representation of the person's names, birthdate, gender, and nationality.
        /// </returns>
        public override string ToString()
        {
            return $"Person's Details" +
                   $"\n" + new string('-', 55) +
                   $"\nNames: {this.Names}" +
                   $"\nDate of Birth: {this.BirthDate}" +
                   $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
                   $"\nNationality: {this.Nationality}" +
                   $"\n" + new string('-', 55);
        }
    }

    public class DemoSimplerPerson
    {
        static void Main(string[] args)
        {
            // Declare and instantiate a SimplerPerson object
            SimplerPerson myBuddy = new SimplerPerson();
            // Prompt the user for the details of their friend or buddy
            Console.WriteLine(@"Please enter your buddy's name:");
            myBuddy.Names = Console.ReadLine();
            Console.WriteLine(@"Please enter your buddy's birthdate:");
            myBuddy.BirthDate = DateTime.Parse(Console.ReadLine());
            // myBuddy.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(@"Please enter your buddy's gender using 'm' for male or 'f' for female:");
            myBuddy.Gender = char.Parse(Console.ReadLine());
            Console.WriteLine(@"Please enter your buddy's nationality:");
            myBuddy.Nationality = Console.ReadLine();

            // Display my buddy's details
            Console.WriteLine(myBuddy);
        }
    }
}