using System.Data;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// This class will be used to create a Person object & later inherited 
    /// to create specialised classes
    /// </summary>
    public class SimplePerson
    {
        //Instance fields
        protected string names;
        protected DateTime birthDate;
        protected string gender;
        protected string nationality;

        public SimplePerson()
        {
            this.names = string.Empty;
            this.birthDate = DateTime.MinValue;
            this.gender = string.Empty;
            this.nationality = string.Empty;
        }

        public string GetNames()
        {
            return this.names;
        }
        public void SetNames(string names) { this.names = names; }

        public DateTime GetBirthDate()
        {
            return this.birthDate;
        }
        public void setBirthDate(DateTime birthDate) { this.birthDate = birthDate; }

        public string GetGender()
        {
            return this.gender;
        }
        public void setGender(string gender) { this.gender = gender; }

        public string GetNationality()
        {
            return this.nationality;
        }
        public void SetNationality(string nationality) { this.nationality = nationality; }

        public override string ToString()
        {
            return $"Person's Details" +
                   $"\n------------------------------------------" +
                   $"\nName: {this.GetNames()}" +
                   $"\nDate of Birth: {this.GetBirthDate()}" +
                   $"\nGender: {this.GetGender()}" +
                   $"\nNationality: {this.GetNationality()}" +
                   $"\n------------------------------------------\n";
        }
    }
}
