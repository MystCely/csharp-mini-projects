namespace crocodile_game;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();
        
        bool gameOver = false;
        int score = 0;
        Random rand = new Random();
        
        while (!gameOver)
        {
            var randomNumber = rand.Next(1, 12);
            var randomNumber2 = rand.Next(1, 12);
        
            Console.WriteLine($"{randomNumber} _ {randomNumber2}");
        
            string answer = input.AskForInput("Please choose between <, > or =");

            if (answer != "<" && answer != ">" && answer != "=")
            {
                gameOver = true;
                Console.WriteLine("\nGame over! You gave an answer that wasn't <, > or =\n");
                continue;
            } 
            
            if (randomNumber > randomNumber2 && answer == ">")
            {
                score++;
                Console.WriteLine($"\nYou got it right! Your score is {score}\n");
            }
            else if (randomNumber < randomNumber2 && answer == "<")
            {
                score++;
                Console.WriteLine($"\nYou got it right! Your score is {score}\n");
            } 
            else if (randomNumber == randomNumber2 && answer == "=")
            {
                score++;
                Console.WriteLine($"\nYou got it right! Your score is {score}\n");
            }
            else
            {
                score--;
                Console.WriteLine($"\nYou got it wrong! Your score is {score}\n");
            }

            
            if (score <= 0)
            {
                gameOver = true;
                Console.WriteLine($"Game over!");
            }
        }
        
    }
    
}
