namespace LibrarySystem;

public class Library
{
    public List<Book> Books { get; set;}

    public Library(List<Book> books)
    {
        Books = books;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public Book SearchBook(string title)
    {
        var cleanTitle = title.Trim();
        
        if (string.IsNullOrEmpty(cleanTitle))
        {
            return null;
        }
        
        var chosenBook = Books.Find(book => book.Title.Contains(cleanTitle, StringComparison.OrdinalIgnoreCase));

        return chosenBook;
    }

    public int SearchYear(Input input)
    {
        int year = 0;
        bool isValid = false;

        while (!isValid)
        {
            var yearStr = input.AskForInput("Enter the year published of the book: ").Trim();
                        
            if (int.TryParse(yearStr, out year))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("\nInvalid year. Please enter a number.");
            }
        }
        return year;
    }
}