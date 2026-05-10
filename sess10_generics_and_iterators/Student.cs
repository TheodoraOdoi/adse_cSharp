namespace sess10_generics_and_iterators
{
    /// <summary>
    /// Represents a student with basic details such as Student Number, Names, BirthDate, Gender(binary), email, course, current semester and Nationality.
    /// </summary>
    public class Student : Person
    {
        // Student properties

        /// <summary>
        /// Gets or sets the student's Student Number
        /// </summary>
        public string StudentNo { get; set; }
        /// <summary>
        /// Gets or sets the student's Course
        /// </summary>
        public string Course { get; set; }
        /// <summary>
        /// Gets or sets the student's current semester
        /// </summary>
        public byte CurrentSem { get; set; }

        public Student() : base()
        {
            this.StudentNo = string.Empty;
            this.Course = string.Empty;
            this.CurrentSem = 1;
        }

        public Student(string names, DateTime dob, char gender, string email, string nationality, string studNo, string course, byte currSem) : base(names, dob, gender, email, nationality)
        {
            this.StudentNo = studNo;
            this.Course = course;
            this.CurrentSem = currSem;
        }

        /// <summary>
        /// Returns a formatted string representation of the student's details.
        /// </summary>
        /// <returns>
        /// A human-readable string representation of the student's student number, names, birthdate, gender, email, course, current semester, and nationality.
        /// </returns>
        public override string? ToString()
        {
            return $"Student's Details" +
               $"\n" + new string('-', 55) +
               $"\nStudent Number: {this.StudentNo}" +
               $"\nNames: {this.Names}" +
               $"\nDate of Birth: {this.BirthDate}" +
               $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
               $"\nEmail Address: {this.Email}" +
               $"\nCourse: {this.Course}" +
               $"\nCurrent Semester: {this.CurrentSem}" +
               $"\nNationality: {this.Nationality}" +
               $"\n" + new string('-', 55);
        }
    }
}