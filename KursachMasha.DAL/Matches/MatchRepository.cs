using Npgsql;
using System.Text;

namespace KursachMasha.DAL.Mathes;
public class MatchRepository :
    SqlWorker<Match>
    , ISqlWorkerEntity<Match, MatchFilter>
{
    protected override string Table => "matches";

    public void Add(Match obj)
    {
        var query = $"insert into {Table} (date, team1_id, team2_id, stadium_id, team1_result, team2_result)" +
            $"values ('{obj.DateTime}', '{obj.Team1ID}', '{obj.Team2ID}', '{obj.StadiumID}', {obj.ResultTeam1}, {obj.ResultTeam2});";
        ExecuteQuery(query);
    }

    public Match GetByID(int id)
    {
        var query = "SELECT " +
         $"m.id, m.date, m.team1_id, t1.name, m.team2_id, t2.name, m.stadium_id, s.name, m.team1_result, m.team2_result" +
         $"\r\n\tFROM matches m " +
         $"\r\n\tINNER JOIN teams t1 ON m.team1_id = t1.id " +
         $"\r\n\tINNER JOIN teams t2 ON m.team2_id = t2.id " +
         $"\r\n\tINNER JOIN stadiums s ON m.stadium_id = s.id" +
         $"\r\n\twhere m.id = {id}";

        return base.ExecuteGetQuery(query);
    }

    public void Update(Match obj)
    {
        var query = $"update {Table} " +
                        $"set " +
                        $"date = '{obj.DateTime}'" +
                        $", team1_id = '{obj.Team1ID}'" +
                        $", team2_id = '{obj.Team2ID}'" +
                        $", stadium_id = {obj.StadiumID}" +
                        $", team1_result = {obj.ResultTeam1}" +
                        $", team2_result = {obj.ResultTeam2}" +
                    $"\nwhere id = {obj.ID};";

        base.ExecuteQuery(query);
    }

    protected override Match Map(NpgsqlDataReader sqlDataReader)
        => new Match()
        {
            ID = sqlDataReader.GetInt32(0),
            DateTime = sqlDataReader.GetDateTime(1),
            Team1ID = sqlDataReader.GetInt32(2),
            Team1Name = sqlDataReader.GetString(3),
            Team2ID = sqlDataReader.GetInt32(4),
            Team2Name = sqlDataReader.GetString(5),
            StadiumID = sqlDataReader.GetInt32(6),
            StadiumName = sqlDataReader.GetString(7),
            ResultTeam1 = sqlDataReader.GetInt32(8),
            ResultTeam2 = sqlDataReader.GetInt32(9),
        };

    public Match[] GetArray(MatchFilter filter)
    {
        if (filter is null)
            filter = new MatchFilter();

        var sql = $"select * from get_info_matches('{filter.Search ?? ""}'" +
            $",{filter.Team1ID?.ToString() ?? "null"}" +
            $",{filter.Team2ID?.ToString() ?? "null"}" +
            $",{filter.StadiumID?.ToString() ?? "null"})";

        return base.ExecuteGetArrayQuery(sql);
    }

    
}

