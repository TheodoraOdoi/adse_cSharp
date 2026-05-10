

namespace Edulink_Student_Staff_WPF_DB
{
    /// <summary>
    /// Represents a staff member with basic details such as StaffId, Names, BirthDate, Gender(binary),
    /// employment date, designation, phone number, email, and Nationality.
    /// </summary>
    public class Staff : Person
    {
        // Staff properties
        /// <summary>
        /// Gets or sets the staff member's Staff ID
        /// </summary>
        public string StaffID { get; set; }
        /// <summary>
        /// Gets or sets the staff member's date of employment
        /// </summary>
        public DateTime EmployementDate { get; set; }
        /// <summary>
        /// Gets or sets the staff member's designation (job title)
        /// </summary>
        public string Designation { get; set; }
        /// <summary>
        /// Gets or sets the staff member's phone number
        /// </summary>
        public string PhoneNo { get; set; }

        public Staff() : base()
        {
            this.StaffID = "";
            this.EmployementDate = new DateTime();
            this.Designation = string.Empty;
            this.PhoneNo = string.Empty;
        }

        public Staff(string names, DateTime dob, char gender, string email, string nationality,
            string staffID, DateTime employmentDate, string designation, string phoneNo) :
            base(names, dob, gender, email, nationality)
        {
            this.StaffID = staffID;
            this.EmployementDate = employmentDate;
            this.Designation = designation;
            this.PhoneNo = phoneNo;
        }
    }
}
