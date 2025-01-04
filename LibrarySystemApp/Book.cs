public class Book
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }
    public Author Author { get; set; }

    // Parameterless constructor
    public Book()
    {
        Title = "Unknown Title";
        ISBN = "Unknown ISBN";
        PublicationYear = 0;
        Author = new Author();
    }

    // Parameterized constructor
    public Book(string title, string isbn, int publicationYear, Author author)
    {
        Title = title;
        ISBN = isbn;
        PublicationYear = publicationYear;
        Author = author;
      
    }
}
