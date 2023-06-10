namespace Kursach.DAL.Users;
public class User
{
    public int ID { get; init; }

    public string Login { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}
