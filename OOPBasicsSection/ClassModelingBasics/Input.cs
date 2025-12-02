namespace ClassModelingBasics;

public class Input
{
    public string AskForPokemon(string question)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        return input;
    }
}