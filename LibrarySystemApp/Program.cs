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

        Console.WriteLine($"Welcome to {library.Name}");
        Console.WriteLine("Select an option: ");
        Console.WriteLine("1: Display all books\n2: Add book\n3: Borrow book\n4: Return book\n5: Exit");
        bool exit = false;
        while (!exit)
        {
            Console.Write("Your choice: ");
            if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 5)
            {
                Console.WriteLine("Invalid input, please enter a number between 1 and 5.");
                continue;
            }

            switch (option)
            {
                case 1:
                    library.ListBooks();
                    break;

                case 2:
                    Console.WriteLine("Add a New Book to the Library");
                    Book bookObj = new Book();
                    bookObj.NewBook(library);
                    break;

                case 3:
                    Console.WriteLine("Borrow a Book");
                    library.BorrowBook();
                    break;

                case 4:
                    Console.WriteLine("Return a Book");
                    library.ReturnBook();

                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}

