namespace MethodOverloadingDemo;

internal class Welcome
{

    public string Message;

    public Welcome(string message)
    {
        Message = message;
    }

    public void PrintWelcomeMsg()
    {
        Console.WriteLine(Message);
    }
    
    public void PrintWelcomeMsg(string compliment)
    {
        Console.WriteLine(Message + compliment);
    }
    
}