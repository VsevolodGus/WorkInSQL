using Npgsql;
using System.Data.SqlClient;
using System.Text;

namespace KursachMasha.DAL.Players;
public class PlayerRepository :
    SqlWorker<Player>
    , ISqlWorkerEntity<Player, PlayerFilter>
{
    public PlayerRepository() : base()
    { }

    protected override string Table => "players";

    public void Update(Player sponsor)
    {
        var query = $"update from {Table} " +
                        $"set " +
                        $"Name = {sponsor.Name}" +
                        $", team_id = {sponsor.TeamID}" +
                        $", description = {sponsor.Description}" +
                    $"where id = {sponsor.ID};";

        ExecuteQuery(query);
    }

    public void Delete(int id)
    {
        var query = $"delete from {Table} " +
                    $"where id = {id}"; ;

        ExecuteQuery(query);
    }

    public void Add(Player obj)
    {
        var query = $"insert into {Table} (name, team_id, description)" +
            $"values ({obj.Name}, {obj.TeamID} ,{obj.Description});";

        ExecuteQuery(query);
    }

    public Player[] GetArray(PlayerFilter filter)
    {
        var stringBuilder = new StringBuilder($"SELECT id, name, surname, patronymic, number_in_team, team_id, role_id" +
            $"\r\n\tFROM public.players" +
            $"\r\n\twhere 1 = 1");

        if (!string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($"and name like %{filter.Search}%");

        if (filter.TeamID.HasValue)
            stringBuilder.Append($"and team_id = %{filter.TeamID}%");

        stringBuilder.Append(';');

        var sql = stringBuilder.ToString();
        return ExecuteGettingQuery(stringBuilder.ToString());
    }

    protected override Player Map(NpgsqlDataReader sqlDataReader)
    {
        return new Player()
        {
            ID = sqlDataReader.GetInt32(0),
            Name = sqlDataReader.GetString(1),
            Surname = sqlDataReader.GetString(2),
            Patronymic = sqlDataReader.GetString(3),
            Number = sqlDataReader.GetInt32(4),
            TeamID = sqlDataReader.GetInt32(5),
            RoleID= sqlDataReader.GetInt32(6),
        };
    }
}
