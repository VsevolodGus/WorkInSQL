
using Npgsql;
using System.Text;

namespace KursachMasha.DAL.Teams;
public class TeamRepository :
    SqlWorker<Team>
    , ISqlWorkerEntity<Team, TeamFilter>
{
    protected override string Table => "teams";

    public void Add(Team sponsor)
    {
        throw new NotImplementedException();
    }

    public void Update(Team sponsor)
    {
        throw new NotImplementedException();
    }

    public Team[] GetArray(TeamFilter filter = null)
    {
        if (filter is null)
            filter = new TeamFilter();
        
        var stringBuilder = new StringBuilder($"SELECT id, name, sponsor_id" +
            $"\r\n\tFROM public.{Table}" +
            $"\r\n\twhere 1 = 1");

        if (!string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($"\nand name like '%{filter.Search}%'");

        if (filter.SponsorID.HasValue)
            stringBuilder.Append($"and sponsor_id = %{filter.SponsorID}%");

        stringBuilder.Append(';');
        return ExecuteGettingQuery(stringBuilder.ToString());
    }

   

    protected override Team Map(NpgsqlDataReader sqlDataReader)
        => new Team()
        {
            ID = sqlDataReader.GetInt32(0),
            Name = sqlDataReader.GetString(1),
            SponsorID = sqlDataReader.GetInt32(2),
        };
}
