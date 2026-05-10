namespace sess10_generics_and_iterators
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

        /// <summary>
        /// Returns a formatted string representation of the staff member's details.
        /// </summary>
        /// <returns>
        /// A human-readable string representation of the staff member's staff id, names, birthdate, gender,
        /// employment date, designation (job title), years served, email, phone number, and nationality.
        /// </returns>
        public override string? ToString()
        {
            return $"Person's Details" +
                   $"\n" + new string('-', 55) +
                   $"\nStaff ID: {this.StaffID}" +
                   $"\nNames: {this.Names}" +
                   $"\nDate of Birth: {this.BirthDate}" +
                   $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
                   $"\nEmployment Date: {this.EmployementDate}" +
                   $"\nDesignation/Job Title: {this.Designation}" +
                   $"\nYears Served: {DateTime.Now.Year - this.BirthDate.Year} years." +
                   $"\nEmail Address: {this.Email}" +
                   $"\nPhone Number: {this.PhoneNo}" +
                   $"\nNationality: {this.Nationality}" +
                   $"\n" + new string('-', 55);
        }
    }
}