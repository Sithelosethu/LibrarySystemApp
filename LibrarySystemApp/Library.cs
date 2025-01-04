using System;
using System.Collections.Generic;

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    // Parameterless constructor
    public Library()
    {
        Name = "Unknown Library";
        Books = new List<Book>();
    }

    // Parameterized constructor
    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    // Method to list all books in the library
    public void ListBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, ISBN: {book.ISBN}, Publication Year: {book.PublicationYear}, Author: {book.Author.Name}");
        }
    }
}
