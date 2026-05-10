

namespace Edulink_Student_Staff_WPF_DB
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
    }
}
