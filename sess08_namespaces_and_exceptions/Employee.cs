using sess07_properties_records_indexers;

namespace sess08_namespaces_and_exceptions
{

    /// <summary>
    /// Represents an employee object with details derived from <see cref="SimplerPerson"/> class and the employee's ID.
    /// </summary>
    public class Employee : SimplerPerson
    {
        /// <summary>
        /// Gets or sets the employee's unique identifier.
        /// </summary>
        public uint EmpID { get; set; }

        /// <summary>
        /// Returns a formatted string representation of the employee's details.
        /// </summary>
        /// <returns>
        /// A human-readable string representation of the employee's ID, names, birthdate, gender, and nationality.
        /// </returns>
        public override string ToString()
        {
            return $"Employee's Details" +
                   $"\n" + new string('-', 55) +
                   $"\nEmployee ID: {this.EmpID}" +
                   $"\nNames: {this.Names}" +
                   $"\nDate of Birth: {this.BirthDate}" +
                   $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
                   $"\nNationality: {this.Nationality}";
        }
    }

    namespace Salary
    {
        class SalaryDetails
        {
            public double EmployeeSalary { get; set; }

            public override string ToString()
            {
                return $"\nSalary Amount: Kes. {this.EmployeeSalary}" +
                       $"\n" + new string('-', 55);
            }
        }
    }
}