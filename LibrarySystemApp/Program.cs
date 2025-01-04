public class Program
{
    public static void Main(string[] args)
    {
        // Create an author
        Author author1 = new Author("Neil Gaiman", new DateTime(1960, 11, 10));

        // Create books
        Book book1 = new Book("Neverwhere", "978-0060557812", 1996, author1);
        Book book2 = new Book("American Gods", "978-0062080233", 2001, author1);

        // Create a library
        Library library = new Library("VC Library");

        // Add books to the library
        library.AddBook(book1);
        library.AddBook(book2);

        // List all books in the library
        library.ListBooks();
    }
}
