namespace KursachMasha.DAL.Users;
public class User
{
    public Guid ID { get; init; }

    public string Login { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}
