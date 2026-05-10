namespace sess07_properties_records_indexers
{

    /// <summary>
    /// Program to demonstrate the use of Indexers in C#
    /// </summary>
    public class BookIndexer
    {
        // Create an array of programming books
        private Book[] programmingBooks = new[]
        {
        new Book(578, "C# How to Program", "Deitel & Deitel", 7100.0f),
        new Book(579, "C# Notes for Professionals", "Et al", 0.0f),
        new Book(580, "Java the Complete Reference", "Oracle Inc.", 11710.4f),
        new Book(581, "Web Scraping with Python", "Ryan Mitchelle", 5930.0f),
        new Book(582, "Fundamentals of Web Development", "Randy & Ricardo", 9700.0f)
    };

        // Set up the book index
        public Book this[uint bookId]
        {
            get { return programmingBooks[bookId]; }
        }

        static void Main(string[] args)
        {
            // Display the programming books with aid of a for...each loop using the indexer
            foreach (Book book in new BookIndexer().programmingBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}