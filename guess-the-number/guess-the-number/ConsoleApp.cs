namespace guess_the_number;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();

        Random rand = new Random();
        int randomNum = rand.Next(1, 101);

        bool gameOver = false;

        while (!gameOver)
        {
            int inputNum;

            while (true)
            {
                string stringInput = input.AskForInput("\nChoose a number between 1-100");
                if (int.TryParse(stringInput, out inputNum) && inputNum >= 1 && inputNum <= 100)
                {
                    break;
                }
                Console.WriteLine("\nPlease enter a valid number between 1-100.\n");
            }

            int numDifference = Math.Abs(inputNum - randomNum);

            if (inputNum == randomNum)
            {
                Console.WriteLine($"\nYAY! You won the game! You guessed the number {randomNum} correctly!\n");
                string playAgain = input.AskForInput("Want to play again? Please answer with Yes/No");

                if (playAgain == "Yes")
                {
                    randomNum = rand.Next(1, 101);
                    continue;
                }
                
                else if (playAgain == "No")
                {
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("You didn't answer with a valid option. Restart the program to play again.");
                    gameOver = true;
                }
            }
            
            else if (inputNum < randomNum)
            {
                Console.WriteLine("You're lower than the number. You can do it!\n");
            } 
            else if (inputNum > randomNum)
            {
                Console.WriteLine("Oops! That's a bit high.\n");
            }
        }
        
    }

    
}
