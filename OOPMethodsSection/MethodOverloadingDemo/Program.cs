namespace MethodOverloadingDemo;

class Program
{
    static void Main(string[] args)
    {
        var welcome = new Welcome("Hi and welcome! ");
        
        welcome.PrintWelcomeMsg("Du er snill!");
    }
}