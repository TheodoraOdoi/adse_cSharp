namespace sess07_properties_records_indexers
{
    /// <summary>
    ///  Represents a book object with basic details such as ID, title, author and price
    /// </summary>
    public class Book
    {
        // Props
        /// <summary>
        /// Gets or sets the book's unique identifier
        /// </summary>
        public uint BookID { get; set; }

        /// <summary>
        /// Gets or sets the book's title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the book's author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the book's price
        /// </summary>
        public float Price { get; set; }

        //  Constructors
        /// <summary>
        /// Initialises a new instance of the <see cref="Book"/> class with default values.
        /// </summary>
        public Book()
        {
            this.BookID = 0;
            this.Title = string.Empty;
            this.Author = string.Empty;
            this.Price = 0.0f;
        }

        /// <summary>
        ///  Initialises a new instance of the <see cref="Book"/> class with specified values.
        /// </summary>
        /// <param name="bookID">The book's unique identifier</param>
        /// <param name="title">The book's title</param>
        /// <param name="author">The book's author</param>
        /// <param name="price">The book's price (default currency is Kenyan Shillings, KES.)</param>
        public Book(uint bookID, string title, string author, float price)
        {
            this.BookID = bookID;
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        /// <summary>
        /// Returns a formatted string containing the books details.
        /// </summary>
        /// <returns>
        /// A string representation of the book including its ID, title, author, and price.
        /// </returns>
        public override string ToString()
        {
            return $"Book Details" +
                   $"\n" + new string('-', 55) +
                   $"\nBook ID: {this.BookID}" +
                   $"\nBook Title: {this.Title}" +
                   $"\nBook Author: {this.Author}" +
                   $"\nBook Price: Kes. {this.Price:N2}" +
                   $"\n" + new string('-', 55);
        }
    }
}