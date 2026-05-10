namespace sess07_properties_records_indexers
{
    /// <summary>
    /// Represents a person with basic details such as name, age, and email.
    /// </summary>
    /// <param name="Name">The person's full name.</param>
    /// <param name="Age">The person's age.</param>
    /// <param name="Email">The person's email.</param>
    public record Person(string Name, byte Age, string Email)
    {
        /// <summary>
        /// Overrides the default <see cref="ToString"/> method to give a custom string representing
        /// the person's details.
        /// </summary>
        /// <returns>
        /// A human-readable representation of the person's name, age, and email.
        /// </returns>
        public override string ToString()
        {
            return $"Person's Details" +
                  $"\n" + new string('-', 55) +
                  $"\nNames: {this.Name}" +
                  $"\nAge: {this.Age}" +
                  $"\nEmail: {this.Email}" +
                  $"\n" + new string('-', 55); ;
        }
    }

    public record Student(
        string Name,
        byte Age,
        string Email,
        string StudentID,
        char Gender,
        DateTime EnrollDate
    ) : Person(Name, Age, Email)
    {
        /// <summary>
        /// Overrides the Person's <see cref="ToString"/> method to give a custom string representing
        /// the student's details.
        /// </summary>
        /// <returns>
        /// A human-readable representation of the student's name, age, email, studentID, gender and enrollment date.
        /// </returns>
        public override string ToString()
        {
            return $"Student's Details" +
                   $"\n" + new string('-', 55) +
                   $"\nNames: {this.Name}" +
                   $"\nAge: {this.Age}" +
                   $"\nEmail: {this.Email}" +
                   $"\nStudentID: {this.StudentID}" +
                   $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
                   $"\nEnrollment Date: {this.EnrollDate}" +
                   $"\n" + new string('-', 55); ;
        }
    }

    public class RecordsDemo
    {
        public static void Main()
        {
            // Declare and initialise a Person record
            Person person = new Person("Wanjiku", 18, "wanjiku@email.com");
            // Display the person's details
            Console.WriteLine(person);

            // Declare and initialise a Student record
            Student s1 = new Student("Wanjiru Kamau", 16, "ciru@email.com", "S001", 'F',
                new DateTime(2022, 05, 22));
            var s2 = new Student(
                Name: "James Muithya",
                Age: 20,
                Email: "j.muithya@edulink.ac.ke",
                StudentID: "S002",
                Gender: 'M',
                EnrollDate: new DateTime(2023, 09, 01));

            // Display the above student's details
            Console.WriteLine(s1 + "\n" + s2);

            // Modify/update student 2's details
            var updatedS1 = s1 with { Age = 21, Email = "w.kamau@edulink.ac.ke" };
            // Display the modified student 1's details
            Console.WriteLine($"Modified S1: {updatedS1}");
        }
    }
}