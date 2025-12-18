namespace BossFight;

public class ConsoleApp
{
    public void Run()
    {
        Console.WriteLine("Welcome to Boss Fight!\n");
        Console.WriteLine("Press P to start the fight!\n");
        
        var key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.P)
        {
            
            var hero = new GameCharacter("Hero", 100, 20, 40, false);
            var boss = new GameCharacter("Boss", 400, 0, 10, true);
        
            while (!hero.IsDead && !boss.IsDead)
            {
                hero.Fight(boss);

                if (boss.IsDead)
                {
                    Console.WriteLine($"\n{hero.Name} won the fight!");
                    return;
                }
        
                boss.Fight(hero);

                if (hero.IsDead)
                {
                    Console.WriteLine($"\n{boss.Name} won the fight!");
                    return;
                }
            }
        }
        
        else
        {
            Console.WriteLine("You didn't press P. Please run the program to try again.");
        }
        
    }
}