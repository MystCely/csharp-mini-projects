namespace RobotBuddy;

public class Robot
{
    private string Name { get; set; }
    private int BatteryLevel { get; set; }
    private int Mood { get; set; }
    private bool NeedsRepair { get; set; }

    public Robot(string name, int batteryLevel, int mood, bool needsRepair)
    {
        Name = name;
        BatteryLevel = batteryLevel;
        Mood = mood;
        NeedsRepair = needsRepair;
    }

    public void Charge()
    {
        Mood -= 3;
        BatteryLevel += 10;
        Console.WriteLine($"Robot battery level is now {BatteryLevel}%");
        
        EnforceLimits();

    }

    public void Talk()
    {
        BatteryLevel -= 10;
        Mood += 10;
        
        if (BatteryLevel <= 20)
        {
            Mood -= 20;
        }
        
        EnforceLimits();
        
        if (Mood >= 80)
        {
            Console.WriteLine("Robot is happy!");
        }
        else if (Mood >= 60)
        {
            Console.WriteLine("Robot is neutral.");
        }
        else if (Mood >= 40)
        {
            Console.WriteLine("Robot is sad..");
        } 
        else if (Mood >= 20)
        {
            Console.WriteLine("Robot needs immediate attention!");
        }
        
        Console.WriteLine($"Robot mood is now {Mood}%");

    }

    public void CheckMaintenance()
    {
        BatteryLevel -= 5;
        
        if (Mood <= 10 || BatteryLevel <= 10)
        {
            NeedsRepair = true;
        }
        else NeedsRepair = false;
        
        if (NeedsRepair) Console.WriteLine("Robot needs maintenance!");
        if (!NeedsRepair) Console.WriteLine("Robot is fine!");
    }

    public void EnforceLimits()
    {
        if (Mood > 100) Mood = 100;
        if (Mood < 0) Mood = 0;
        if (BatteryLevel > 100) BatteryLevel = 100;
        if (BatteryLevel < 0) BatteryLevel = 0;
    }
}