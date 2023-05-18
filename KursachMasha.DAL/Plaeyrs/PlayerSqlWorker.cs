using System.Data.SqlClient;
using System.Text;

namespace KursachMasha.DAL.Players;
internal class PlayerSqlWorker :
    SqlWorker<Player>
    , ISqlWorkerEntity<Player, PlayerFilter>
{
    public PlayerSqlWorker() : base()
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
        var stringBuilder = new StringBuilder("select * from {Table} where 1 = 1");

        if (string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($"and name like %{filter.Search}%");

        if (filter.TeamID.HasValue)
            stringBuilder.Append($"and team_id = %{filter.TeamID}%");

        stringBuilder.Append(';');


        return ExecuteGettingQuery(stringBuilder.ToString());
    }

    protected override Player Map(SqlDataReader sqlDataReader)
    {
        return new Player()
        {
            ID = sqlDataReader.GetInt32(0),
            Name = sqlDataReader.GetString(1),
            TeamID = sqlDataReader.GetInt32(2),
            Description = sqlDataReader.GetString(3),
        };
    }
}
