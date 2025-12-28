namespace LibrarySystem;

public class Input
{
    public string AskForInput(string question)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        return input;
    }
}