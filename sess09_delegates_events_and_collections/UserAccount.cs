using System.ComponentModel.DataAnnotations;

namespace sess09_delegate_events_collections
{
    /// <summary>
    /// This class represents a basic user account with information such as userid, username and password. It can be used
    /// for systems requiring authentication like online account or POS
    /// </summary>
    public class UserAccount
    {
        /// <summary>
        /// Static/Class variable to autogenerate unique userID's starting from 1001
        /// </summary>
        private static long initialID = 1001L;
        /// <summary>
        /// Retrieve/fetches the unique identifier for the user account
        /// This property is read-only and is autoamtically assigned during user account creation
        /// </summary>
        [Key]
        [Required]
        public long UserID { get; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(8), MaxLength(15)]
        public string Password { get; set; }

        /// <summary>
        /// Initialise a new instance of the <see cref="UserAccount"/> calss with a specified username and password
        /// The usuerID is automatically assigned from a static counter thatincrement with each new instance
        /// </summary>
        /// <param name="username">The username associated with the account</param>
        /// <param name="password">Password associated and used to access the account</param>
        public UserAccount(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.UserID = initialID++;
        }

        /// <summary>
        /// Returns astring representation of the <see cref="UserAccount"/> object including
        /// the userID, usename, and a masked/obscured version of the account password.
        /// This password will be partially masked to ensure privacy. (Only the first and the last characters are visible)
        /// </summary>
        /// <returns>
        /// A string representation of the account's userID, username and masked version of the password
        /// </returns>
        public override string ToString()
        {
            return $"User Account Information" +
                $"\n" + new string('-', 50) +
                $"\n User ID: {this.UserID}" +
                $"\n Username: {this.Username}" +
                $"\n Password: {this.Password.Remove(1, (this.Password.Length - 2)).Insert(1, "************")}" +
                $"\n" + new string('-', 55);
        }
    }
}
