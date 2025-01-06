public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public Library()
    {
        Name = "Unknown Library";
        Books = new List<Book>();
    }

    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void ListBooks()
    {
        foreach (var book in Books)
        {
            string status = book.IsBorrowed ? "Borrowed" : "Available";
            Console.WriteLine($"Title: {book.Title}, ISBN: {book.ISBN}, Year: {book.PublicationYear}, Author: {book.Author.Name}, Status: {status}");
        }
    }

    public void BorrowBook()
    {
        Console.WriteLine("Available Books:");
        ListBooks();

        Console.Write("Enter the ISBN of the book to borrow: ");
        string bookISBN = Console.ReadLine();

        var book = Books.Find(b => b.ISBN == bookISBN);

        if (book != null)
        {
            if (book.IsBorrowed)
            {
                Console.WriteLine("This book is already borrowed.");
            }
            else
            {
                book.IsBorrowed = true;
                Console.WriteLine($"You have successfully borrowed '{book.Title}'.");
            }
        }
        else
        {
            Console.WriteLine("Book not found. Please check the ISBN and try again.");
        }
    }

    public void ReturnBook()
    {
        Console.Write("Enter the ISBN of the book to return: ");
        string bookISBN = Console.ReadLine();

        var book = Books.Find(b => b.ISBN == bookISBN);

        if (book != null)
        {
            if (book.IsBorrowed)
            {
                book.IsBorrowed = false;
                Console.WriteLine($"You have successfully returned '{book.Title}'.");
            }
            else
            {
                Console.WriteLine("This book was not borrowed.");
            }
        }
        else
        {
            Console.WriteLine("Book not found. Please check the ISBN and try again.");
        }
    }
}
