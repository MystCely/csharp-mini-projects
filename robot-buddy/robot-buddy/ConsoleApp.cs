namespace RobotBuddy;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();
        
        Console.WriteLine("Welcome to Robot Buddy!");
        
        string name = input.AskForInput("\nWhat is your robot's name?");
        
        var robot = new Robot(name, 100, 100, false);
        
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Charge robot");
            Console.WriteLine("2. Talk to robot");
            Console.WriteLine("3. Check maintenance");
            Console.WriteLine("4. Exit");

            var choice = input.AskForInput("\nWhat would you like to do?");

            switch (choice)
            {
                case "1": 
                    robot.Charge();
                    break;
                case "2": 
                    robot.Talk();
                    break;
                case "3": 
                    robot.CheckMaintenance();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
}