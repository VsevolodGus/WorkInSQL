using Npgsql;
using System.Text;

namespace KursachMasha.DAL.Teams;
public class TeamRepository :
    SqlWorker<Team>
    , ISqlWorkerEntity<Team, TeamFilter>
{
    protected override string Table => "teams";

    public void Add(Team obj)
    {
        var query = $"insert into {Table} (name, sponsor_id, count_active_players)" +
            $"values ('{obj.Name}', '{obj.SponsorID}', 0);";

        ExecuteQuery(query);
    }

    public void Update(Team obj)
    {
        var query = $"update {Table} " +
                       $"\n\tset " +
                       $"\n\tname = '{obj.Name}'" +
                       $"\n\t, sponsor_id = {obj.SponsorID}" +
                   $"\nwhere id = {obj.ID};";

        ExecuteQuery(query);
    }

    public Team[] GetArray(TeamFilter filter = null)
    {
        if (filter is null)
            filter = new TeamFilter();
        
        var stringBuilder = new StringBuilder($"SELECT t.id, t.name, t.sponsor_id, s.name" +
            $"\r\n\tFROM public.{Table} t" +
            $"\r\n\tinner join sponsors s on t.sponsor_id = s.id" +
            $"\r\n\twhere 1 = 1");

        if (!string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($"\nand t.name like '%{filter.Search}%'");

        if (filter.SponsorID.HasValue)
            stringBuilder.Append($"\nand t.sponsor_id = %{filter.SponsorID}%");

        stringBuilder.Append(';');
        return ExecuteGetArrayQuery(stringBuilder.ToString());
    }

   

    protected override Team Map(NpgsqlDataReader sqlDataReader)
        => new Team()
        {
            ID = sqlDataReader.GetInt32(0),
            Name = sqlDataReader.GetString(1),
            SponsorID = sqlDataReader.GetInt32(2),
            SponsorName = sqlDataReader.GetString(3),
        };

    public Team GetByID(int id)
    {
        var query = $"SELECT t.id, t.name, t.sponsor_id, s.name" +
            $"\r\n\tFROM public.{Table} t" +
            $"\r\n\tinner join sponsors s on t.sponsor_id = s.id" +
            $"\r\n\twhere t.id = {id}";

        return base.ExecuteGetQuery(query);
    }
}
