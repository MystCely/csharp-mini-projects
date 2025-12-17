namespace FriendFace;

public class User
{
    public string Username { get; set; }
    public int Age { get; set; }
    public string Bio { get; set; }
    public List<User> Friends { get; private set; }

    public User(string username, int age, string bio)
    {
        Username = username;
        Age = age;
        Bio = bio;
        Friends = new List<User>();
    }

    public void PrintUserInfo()
    {
        Console.WriteLine($"Username: {Username}\nAge: {Age}\nBio: {Bio}\n");
    }

    public void AddFriend(User user)
    {
        if (user == this)
        {
            Console.WriteLine("You can't add yourself as friend.\n");
        } 
        else if (Friends.Contains(user))
        {
            Console.WriteLine("This user is already your friend.\n");
        }
        else
        {
            Friends.Add(user);
            Console.WriteLine("User added as friend.\n");
        }
    }
    
    public void RemoveFriend(User user)
    {
        if (!Friends.Contains(user))
        {
            Console.WriteLine("This user is already NOT your friend.\n");
        }
        else
        {
            Friends.Remove(user);
            Console.WriteLine("User removed as friend.\n");
        }
    }
    
}