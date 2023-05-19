namespace KursachMasha.DAL.Users;
public class UserRepository
{
    private readonly User[] users = new User[] 
    { 
        new User()
        {
            ID = Guid.NewGuid(),
            Login = "admin",
            Password= "admin",
            IsAdmin= true,
        },
        new User()
        {
            ID = Guid.NewGuid(),
            Login = "user",
            Password= "user",
            IsAdmin= false,
        }
    };

    public User GetByLoginAndPassword(string login, string password)
        => users.FirstOrDefault(c=> c.Login.Equals(login) && c.Password.Equals(password));
}
