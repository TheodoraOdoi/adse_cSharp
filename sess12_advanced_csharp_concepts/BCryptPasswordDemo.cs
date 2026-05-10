using static BCrypt.Net.BCrypt;

namespace sess12_advanced_csharp_concepts
{
    /// <summary>
    /// Program to demonstrate encrypting user password.
    /// </summary>
    public class BCryptPasswordDemo
    {static void Main(string[] args)
        {
            // Prompt the user for their password
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            // Use bcypt to hash the password
            string hashedPassword = HashPassword(password, GenerateSalt());

            // Display the hashed password
            Console.WriteLine($"Original password:{password}\nHashed password:{hashedPassword}");
            
            // Verify the user's password
            Console.WriteLine("Please verify/confirm your password -> ");
            string verifyPassword = Console.ReadLine();

            bool isVerified = Verify(verifyPassword, hashedPassword);

            Console.WriteLine(isVerified? "Password verified successfully" : "Password verification failed!");
        }


    }
}
