public class Book
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }
    public Author Author { get; set; }
    public bool IsBorrowed { get; set; }

    public Book()
    {
        Title = "Unknown Title";
        ISBN = "Unknown ISBN";
        PublicationYear = 0;
        Author = new Author();
        IsBorrowed = false;
    }

    public Book(string title, string isbn, int publicationYear, Author author)
    {
        Title = title;
        ISBN = isbn;
        PublicationYear = publicationYear;
        Author = author;
        IsBorrowed = false;
    }


// Method to add a new book
public void NewBook(Library library)
    {
        Console.Write("Enter the title of the book: ");
        string title = Console.ReadLine();

        Console.Write("Enter the ISBN of the book: ");
        string isbn = Console.ReadLine();

        Console.Write("Enter the publication year of the book: ");
        int publicationYear;
        while (!int.TryParse(Console.ReadLine(), out publicationYear) || publicationYear <= 0)
        {
            Console.WriteLine("Invalid year. Please enter a valid positive number.");
        }

        Console.Write("Enter the author's name: ");
        string authorName = Console.ReadLine();

        Console.Write("Enter the author's date of birth (yyyy-mm-dd): ");
        DateTime authorDob;
        while (!DateTime.TryParse(Console.ReadLine(), out authorDob))
        {
            Console.WriteLine("Invalid date. Please enter the date in the format yyyy-mm-dd.");
        }

        // Create an author and a book
        Author newAuthor = new Author(authorName, authorDob);
        Book newBook = new Book(title, isbn, publicationYear, newAuthor);

        // Add the book to the library
        library.AddBook(newBook);

        Console.WriteLine("Book added successfully!");
    }
}
