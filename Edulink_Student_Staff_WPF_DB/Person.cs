

namespace Edulink_Student_Staff_WPF_DB
{
    /// <summary>
    /// Represents a person with basic details such as Names, BirthDate, Gender(binary), email, and Nationality.
    /// </summary>
    public class Person
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
        /// Gets or sets the person's email address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the person's nationality
        /// </summary>
        public string Nationality { get; set; }

        public string GenderDisplay => (Gender == 'M' || Gender == 'm') ? "Male" : "Female";

        /// <summary>
        /// Initialiases a new instance of the <see cref="Person"/> class with default values.
        /// </summary>
        public Person()
        {
            this.Names = "";
            this.BirthDate = DateTime.MinValue;
            this.Gender = 'M';
            this.Email = string.Empty;
            this.Nationality = string.Empty;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Person"/> class with the specified values
        /// </summary>
        /// <param name="names">The person's full names</param>
        /// <param name="dob">The person's date of birth</param>
        /// <param name="gender">The person's binary gender</param>
        /// <param name="email">The person's email address</param>
        /// <param name="nationality">The person's nationality</param>
        public Person(string names, DateTime dob, char gender, string email, string nationality)
        {
            this.Names = names;
            this.BirthDate = dob;
            this.Gender = gender;
            this.Email = email;
            this.Nationality = nationality;
        }
    }
}
