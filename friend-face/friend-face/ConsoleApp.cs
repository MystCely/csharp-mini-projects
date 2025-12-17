namespace FriendFace;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();
        
        Console.WriteLine("\nWelcome to Friend Face! The new social media that takes over the world by storm!\n");
        
        var loggedInUser = new User("Maeve", 23, "I like reading books and drinking milktea.");
    
        Console.WriteLine($"Logged in as: {loggedInUser.Username}");

        List<User> allUsers = new List<User>
        {
            loggedInUser,
            new User("Panda", 7, "I like bamboos."),
            new User("Lyra", 20, "My hobbies are walking around nature."),
            new User("Max", 30, "I love travelling and meeting new people."),
            new User("Diana", 35, "Knitting for my grandkids are my favorite pass time."),
            new User("Cole", 17, "I love gaming in my free time."),
            new User("Leandro", 25, "Looking for my soulmate."),
            new User("Audrey", 24, "Men are disgusting."),
            new User("Marylin", 45, "I can't wait until my family visits me during the holidays!"),
        };

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== FriendFace ===");
            Console.WriteLine("1. Add friend");
            Console.WriteLine("2. Remove friend");
            Console.WriteLine("3. Show my friends");
            Console.WriteLine("4. View friend profile");
            Console.WriteLine("5. Exit");

            string choice = input.AskForInput("\nChoose a number from the available options.");

            int userCount = 1;
            int chosenFriend;
            switch (choice)
            {
                case "1":
                    List<User> availableUsers = new List<User>();
                    
                    for (int i = 0; i < allUsers.Count; i++)
                    {
                        var user = allUsers[i];

                        if (user == loggedInUser)
                        {
                            continue;
                        }
                        if (loggedInUser.Friends.Contains(user))
                        {
                            continue;
                        }
                        
                        Console.WriteLine($"{userCount}: {user.Username}");
                        availableUsers.Add(user);
                        userCount++;
                        
                    }
                    
                    chosenFriend = Convert.ToInt32(input.AskForInput("\nChoose which user to Add:"));

                    chosenFriend -= 1;

                    if (chosenFriend >= 0 && chosenFriend < availableUsers.Count)
                    {
                        var selectedUser = availableUsers[chosenFriend];
                        loggedInUser.AddFriend(selectedUser);
                    }
                    break;
                
                case "2":
                    List<User> friendsToRemove = new List<User>();

                    userCount = 1;

                    if (loggedInUser.Friends.Count == 0)
                    {
                        Console.WriteLine("You have no friends yet.");
                        break;
                    }
                    
                    for (int i = 0; i < loggedInUser.Friends.Count; i++)
                    {
                        var friend = loggedInUser.Friends[i];
                        
                        Console.WriteLine($"{userCount}: {friend.Username}");
                        friendsToRemove.Add(friend);
                        userCount++;
                    }
                    
                    chosenFriend = Convert.ToInt32(input.AskForInput("\nChoose which friend to Remove:"));

                    chosenFriend -= 1;

                    if (chosenFriend >= 0 && chosenFriend < friendsToRemove.Count)
                    {
                        var selectedUser = friendsToRemove[chosenFriend];
                        loggedInUser.RemoveFriend(selectedUser);
                    }
                    break;
                
                case "3":
                    List<User> friendsToView = new List<User>();
                    userCount = 1;

                    for (int i = 0; i < loggedInUser.Friends.Count; i++)
                    {
                        var friend = loggedInUser.Friends[i];
                        
                        Console.WriteLine($"{userCount}: {friend.Username}");
                        friendsToView.Add(friend);
                        userCount++;
                    }
                    break;
                
                case "4":
                    userCount = 1;

                    List<User> friendsProfile = new List<User>();

                    if (loggedInUser.Friends.Count == 0)
                    {
                        Console.WriteLine("You have no friends to view.");
                        break;
                    }
                        
                    for (int i = 0; i < loggedInUser.Friends.Count; i++)
                    {
                        var friend = loggedInUser.Friends[i];
                        
                        Console.WriteLine($"{userCount}: {friend.Username}");
                        friendsProfile.Add(friend);
                        userCount++;
                    }
                    
                    chosenFriend = Convert.ToInt32(input.AskForInput("\nChoose which friend to view their profile:"));

                    chosenFriend -= 1;

                    if (chosenFriend >= 0 && chosenFriend < friendsProfile.Count)
                    {
                        var selectedUser = friendsProfile[chosenFriend];
                        selectedUser.PrintUserInfo();
                    }
                    break;
                
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("You didn't choose one of the available options.");
                    break;
            }
        }
        
    }
}