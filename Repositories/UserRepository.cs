using app.Models;

namespace app.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, UserName = "batman", Password = "123", Role = "manager" });
            users.Add(new User { Id = 1, UserName = "robin", Password = "123", Role = "employee" });
            return users.Where(x => x.UserName.ToLower() == username && x.Password == password).First();
        }
    }
}
