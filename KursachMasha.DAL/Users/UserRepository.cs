using Npgsql;

namespace Kursach.DAL.Users;
public class UserRepository : SqlWorker<User>
{
    protected override string Table => "users";

    public User GetByLoginAndPassword(string login, string password)
    {
        try
        {
            var query = $"select id, login, password, is_admin from {Table}" +
            $"\n\r\twhere login = '{login}' and password = '{password}'";

            return base.ExecuteGetQuery(query);
        }
        catch
        {
            return null;
        }
    }

    protected override User Map(NpgsqlDataReader sqlDataReader)
    {
        return new User() 
        {
            ID = sqlDataReader.GetInt32(0),
            Login = sqlDataReader.GetString(1),
            Password = sqlDataReader.GetString(2),
            IsAdmin = sqlDataReader.GetBoolean(3),
        };
    }
}
