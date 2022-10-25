using Mod12_1;

namespace Mod12_1
{
    public class Program
    {
        static void Main(string [] args)
        {
            List<User> Users = new List<User> ();
            Users.Add(new User("log1", "name 1", true));
            Users.Add(new User("log2", "name 2", false));
            Users.Add(new User("log3", "name 3", true));
            Users.Add(new User("log4", "name 4", false));

            foreach (var user in Users)
            {
                if (user._IsPremium != true)
                {
                    user.ShowAds();
                }
                Console.WriteLine($"{user._Name}, Добрый день");
            }
        }
        
    }
}
