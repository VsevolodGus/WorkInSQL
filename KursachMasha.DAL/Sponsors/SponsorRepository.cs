using Npgsql;
using System.Text;

namespace KursachMasha.DAL.Sponsors;

public sealed class SponsorRepository :
    SqlWorker<Sponsor>
    , ISqlWorkerEntity<Sponsor, SponsorFilter>
{
    public SponsorRepository() : base()
    { }

    protected override string Table => "sponsors";

    public void Update(Sponsor sponsor)
    {
        var query = $"update {Table} " +
                        $"SET " +
                        $"Name = '{sponsor.Name}'" +
                        $", description = '{sponsor.Description}'" +
                    $"\nwhere id = {sponsor.ID};";

        ExecuteQuery(query);
    }

    public void Add(Sponsor sponsor)
    {
        var query = $"insert into {Table} (name, description)" +
            $"values ('{sponsor.Name}', '{sponsor.Description}');";

        ExecuteQuery(query);
    }

    public Sponsor[] GetArray(SponsorFilter filter)
    {
        if(filter is null)
            filter = new SponsorFilter();

        var stringBuilder = new StringBuilder($"select * from {Table}");

        if (!string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($" where name like '%{filter.Search}%'");

        stringBuilder.Append(';');

        var sql = stringBuilder.ToString();
        return ExecuteGetArrayQuery(sql);
    }

    protected override Sponsor Map(NpgsqlDataReader sqlDataReader)
    {
        return new Sponsor()
        {
            ID = sqlDataReader.GetInt32(0),
            Name = sqlDataReader.GetString(1),
            Description = sqlDataReader.GetString(2),
        };
    }

    public Sponsor GetByID(int id)
    {
        var query = $"select * from {Table}" +
            $"\n\twhere id = {id};";

        return ExecuteGetQuery(query);
    }
}
