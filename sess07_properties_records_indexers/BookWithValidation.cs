namespace sess07_properties_records_indexers
{

    // public class BookWithValidation
    // {
    //
    // }
    /// <summary>
    ///  Represents a book object with basic details such as ID, title, author and price
    /// </summary>
    public class BookWithValidation
    {
        private uint _bookID;
        private string _title;
        private string _author;
        private float _price;

        /// <summary>
        /// Gets or sets the book's unique identifier
        /// </summary>
        public uint BookID
        {
            get => _bookID;
            set
            {
                if (value == 0)
                    throw new ArgumentException("BookID must be greater than 0.");
                _bookID = value;
            }
        }

        /// <summary>
        /// Gets or sets the book's title
        /// </summary>
        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be empty.");
                _title = value;
            }
        }

        /// <summary>
        /// Gets or sets the book's author
        /// </summary>
        public string Author
        {
            get => _author;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Author cannot be empty.");
                _author = value;
            }
        }

        /// <summary>
        /// Gets or sets the book's price
        /// </summary>
        public float Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                _price = value;
            }
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Book"/> class with default values.
        /// </summary>
        public BookWithValidation()
        {
            _bookID = 1; // valid default
            _title = string.Empty;
            _author = string.Empty;
            _price = 0.0f;
        }

        /// <summary>
        ///  Initialises a new instance of the <see cref="Book"/> class with specified values.
        /// </summary>
        public BookWithValidation(uint bookID, string title, string author, float price)
        {
            BookID = bookID;   // uses validation
            Title = title;
            Author = author;
            Price = price;
        }

        /// <summary>
        /// Returns a formatted string containing the books details.
        /// </summary>
        public override string ToString()
        {
            return $"Book Details" +
                   $"\n" + new string('-', 55) +
                   $"\nBook ID: {BookID}" +
                   $"\nBook Title: {Title}" +
                   $"\nBook Author: {Author}" +
                   $"\nBook Price: Kes. {Price:N2}" +
                   $"\n" + new string('-', 55);
        }
    }
}