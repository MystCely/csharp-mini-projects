namespace LibrarySystem;

public class ConsoleApp
{
    public void Run()
    {
        
        Console.WriteLine("Welcome to the Library System!");
        
        bool running = true;
        
        var input = new Input();
        var books = new List<Book>
        {
            new Book("Fourth Wing", "Rebecca Yarros", 2023),
            new Book("The Priory of the Orange Tree", "Samantha Shannon", 2019),
            new Book("You Could Be So Pretty", "Holly Bourne", 2023),
            new Book("A Little Life", "Hanya Yanagihara", 2015),
            new Book("Talonsisters", "Jen Williams", 2023),
            new Book("Never Lie", "Freida McFadden", 2022),
            new Book("Throne of Glass", "Sarah J. Maas", 2012),
            new Book("The Poppy War", "R.F. Kuang", 2018),
            new Book("Yellowface", "R.F. Kuang", 2023),
            new Book("Babel", "R.F. Kuang", 2022),
        };
        
        var library = new Library(books);

        while (running)
        {
            
            // Menu
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Search for a book.");
            Console.WriteLine("2. Add a book.");
            Console.WriteLine("3. Remove a book.");
            Console.WriteLine("4. Show all books.");
            Console.WriteLine("5. Exit.");
            
            var choice = input.AskForInput("\nChoose a number from the menu.");

            switch (choice)
            {
                case "1":
                    var bookTitle = input.AskForInput("\nEnter the title of the book you want to search for: ").Trim();
                    var searchBook = library.SearchBook(bookTitle);
                    if (searchBook == null)
                    {
                        Console.WriteLine("\nBook not found.");
                    }
                    else
                    {
                        searchBook.PrintBook();
                    }
                    break;
                
                case "2":
                    var title = input.AskForInput("Enter the title of the book:").Trim();
                    var author = input.AskForInput("Enter the author of the book:").Trim();
                    
                    var yearPublishedInt = library.SearchYear(input);
                    
                    library.AddBook(new Book(title, author, yearPublishedInt));
                    Console.WriteLine("\nBook added successfully!");
                    break;
                
                case "3":
                    var titleToRemove = input.AskForInput("Enter the title of the book: ").Trim();
                    var bookToRemove = library.SearchBook(titleToRemove);

                    if (bookToRemove == null)
                    {
                        Console.WriteLine("\nBook not found.");
                    }
                    else
                    {
                        library.RemoveBook(bookToRemove);
                        Console.WriteLine("\nBook removed successfully!");
                    }
                    break;
                
                case "4":
                    foreach (var book in library.Books)
                    {
                        book.PrintBook();
                    }
                    break;
                
                case "5":
                    running = false;
                    break;
                
                default: 
                    Console.WriteLine("\nInvalid choice.");
                    break;
            }
            
        }
        
    }
}