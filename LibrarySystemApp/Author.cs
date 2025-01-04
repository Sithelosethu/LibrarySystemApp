public class Author
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    // Parameterless constructor
    public Author()
    {
        Name = "Unknown Author";
        DateOfBirth = DateTime.MinValue;
    }

    // Parameterized constructor
    public Author(string name, DateTime dateOfBirth)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
    }
}
