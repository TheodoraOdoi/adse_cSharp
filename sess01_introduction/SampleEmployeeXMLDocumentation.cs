using System.Reflection.Metadata.Ecma335;

namespace sess01_introduction
{
    /// <summary>
    /// Represents an Employyee with an ID,Name and bibary gender
    /// </summary>
   public class SampleEmployeeXMLDocumentation
    {
        /// <summary>
        /// An unsigned integer denoting the employee's unique id
        /// </summary>
        private uint _empID;

        /// <summary>
        /// string field to hold the employee's name
        /// </summary>
        private string _empName;

        /// <summary>
        /// character field to hold the employee's binary gender
        /// </summary>
        /// <remarks>The gender is 'M' for Male and 'F' foe Female.</remarks>
        private string _gender;

        /// <summary>
        /// Initialises a new instance of the <see cref="SampleEmployeeXMLDocumentation"/> 
        /// This constructor sets default values for the employee's id, name, and gender
        /// </summary>
        public SampleEmployeeXMLDocumentation()
        {
            this._empID = 0;
            this._empName = string.Empty; //this._empName
            this._gender = 'M'; // defaults to male
        }

        ///<summary>
        /// initialises a new instance of the <see cref="SampleEmployeeXMLDocumentation"/> with
        /// the specified employee id, name and gender.
        ///</summary>
        ///<param name="id">The employee's unique ID number</param>
        ///<param name="name">The employee's name</param>
        ///<param name="gender">The employee's gender</param>
        public SampleEmployeeXMLDocumentation(uint id, string name, char gender)
        { 
            this._empID = id;
            this._empName = name;
            this._gender = gender;
        }

        /// <summary>
        /// Retrieves/Gets the employee's ID
        /// </summary>
        /// <returns>The employee's ID</returns>
        public uint GetID() { return this._empID; }

        /// <summary>
        /// Assigns/sets the employee's unique ID
        /// </summary>
        /// <param name="id">The employee's unique ID</param>
        public void SetID(uint id) { this._empID = id; }

        /// <summary>
        /// Retrieves the employee's name
        /// </summary>
        /// <returns>The employee's name</returns>
        public string GetName() { return this._empName; }

        /// <summary>
        /// Assigns the employee's name
        /// </summary>
        /// <param name="name">The employee's name</param>
        public void SetName(string name) { this._empName = name; }

        /// <summary>
        /// Retrieves the employee's gender
        /// </summary>
        /// <returns>The employee's gender('M' or'm' for Male & 'F' or 'f' for Female.)</returns>
        public char GetGender() { return this._gender; }

        /// <summary>
        /// Assigns the employee's gender
        /// </summary>
        /// <param name="gender">The employee's gender('M' or'm' for Male & 'F' or 'f' for Female.)</param>
        public void SetGender(char gender) { this._gender = gender; }

        /// <summary>
        /// Returns a string representation of the employee's details
        /// </summary>
        /// <returns>Astring containing the employee's id, name & gender.</returns>
        public override string? ToString()
        {
            return $"Eployee Details" +
                $"\n-------------------------------------------------------------------------------------"+
                $"\nID: {this.GetID}" +
                $"\nName: {this.GetName()}" +
                $"\nGender: {this.GetGender() == 'M' || this.GetGender() == 'm'? "Male":"Female")}"+
                $"\n----------------------------------------------------------------------------------------";

        }
   }
 }
