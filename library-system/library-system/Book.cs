namespace LibrarySystem;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }


    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public void PrintBook()
    {
        Console.WriteLine($"\n{Title} by {Author} ({Year})");
    }
    
}

