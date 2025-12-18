namespace BossFight;

public class GameCharacter
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Strength { get; private set; }
    public int Stamina { get; private set; }
    public int StartingStamina { get; }
    public bool IsBoss { get;  }
    public bool IsDead => Health == 0;
    private Random _random;

    public GameCharacter(string name, int health, int strength, int stamina, bool isBoss)
    {
        Name = name;
        Health = health;
        Strength = strength;
        Stamina = stamina;
        StartingStamina = stamina;
        IsBoss = isBoss;
        
        _random = new Random();
    }
    
    public void Fight(GameCharacter opponent)
    {
        
       if (this.Stamina <= 0)
       {
           Recharge();
           return;
       }

       int damage = Strength;
       if (IsBoss)
       {
           damage = _random.Next(1, 31);
       }
       
       opponent.Health -= damage;
       opponent.Health = Math.Max(0, opponent.Health);
       this.Stamina -= 10;

       Console.WriteLine($"{this.Name} attacked {opponent.Name} with {damage} damage! {opponent.Name} has {opponent.Health} health left.");
    }

    public void Recharge()
    {
        Stamina = StartingStamina;
        Console.WriteLine($"\n{this.Name} recharged stamina!");
    }
    
}