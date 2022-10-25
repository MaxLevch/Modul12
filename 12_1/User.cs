
namespace Mod12_1
{
    public class User
    {
        public string _Login { get; set; }
        public string _Name { get; set; }
        public bool _IsPremium { get; set; }

        public User (string login, string name, bool isPremium)
        {
            _Login = login;
            _Name = name;
            _IsPremium = isPremium;
        }
        public void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными тграми");
            Thread.Sleep(1000);
            Console.WriteLine("Купите подписку");
            Thread.Sleep(2000);
            Console.WriteLine("Оформите премиум- подписку");
            Thread.Sleep(2000);
        }
    }

}
