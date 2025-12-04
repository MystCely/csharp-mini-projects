namespace StudentAdministrationSystem;

public class Input
{
    public string AskForInfo(string question)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        return input;
    }
}