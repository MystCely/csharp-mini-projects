namespace ClassModelingBasics;

class Program
{
    static void Main(string[] args)
    {
        var input = new Input();
        
        var pikachu = new Pokemon("Pikachu", 60, 20);
        var bulbasaur = new Pokemon("Bulbasaur", 30, 10);
        
        Console.WriteLine($"You found {pikachu.Name} and {bulbasaur.Name}!\n");

        string chosenPokemon = input.AskForPokemon("Choose which Pokemon to catch.");

        if (string.IsNullOrWhiteSpace(chosenPokemon))
        {
            Console.WriteLine("You must type a Pokemon name.");
            return;
        }

        if (chosenPokemon != pikachu.Name && chosenPokemon != bulbasaur.Name)
        {
            Console.WriteLine("Please choose one of the found Pokemons.");
            return;
        }

        if (chosenPokemon == pikachu.Name)
        {
            Console.WriteLine($"\nNice! You caught {pikachu.Name}.\nLevel: {pikachu.Level}\nHealth: {pikachu.Health}.");
        }
        else if (chosenPokemon == bulbasaur.Name) 
        {
            Console.WriteLine($"\nNice! You caught {bulbasaur.Name}.\nLevel: {bulbasaur.Level}\nHealth: {bulbasaur.Health}.");
        }

    }
}