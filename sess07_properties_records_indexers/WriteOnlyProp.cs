namespace sess07_properties_records_indexers
{

    /// <summary>
    /// Program to demonstrate a write only property to retrieve/get a user's password
    /// </summary>
    public class WriteOnlyProp
    {
        // Private field to store the user's password
        private string _password;

        public string Password
        {
            set
            { // Set the password using the ternary operator
                _password = value == string.Empty ? "Sup3r$ecretPa55" : _password = value;
            }
        }

        public string Username { get; set; }

        public override string ToString()
        {
            return $"Account Details" +
                   $"\n" + new string('-', 55) +
                   $"\nUsername: {this.Username}" +
                   $"\nPassword: {this._password}" +  // Will not work as _password is write only
                   $"\n" + new string('-', 55);
        }

        static void Main(string[] args)
        {
            // Declare and instantiate a WriteOnlyProp object
            WriteOnlyProp user1 = new WriteOnlyProp();
            // Prompt the user for their username and password
            Console.WriteLine("Please enter your username:");
            user1.Username = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            user1.Password = Console.ReadLine();
            // Display the user's account details
            Console.WriteLine(user1);
        }
    }
}