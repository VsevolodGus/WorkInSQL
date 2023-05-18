using System.Data.SqlClient;
using System.Text;

namespace KursachMasha.DAL.Location;
public class SqlWorkerLocation :
    SqlWorker<Location>
    , ISqlWorkerEntity<Location, LocationFilter>
{
    public SqlWorkerLocation() : base()
    { }

    protected override string Table => "locations";

    public void Update(Location sponsor)
    {
        var query = $"update from {Table} " +
                        $"SET " +
                        $"Name = {sponsor.Name}" +
                    $"where id = {sponsor.ID};";

        ExecuteQuery(query);
    }

    public void Delete(int id)
    {
        var query = $"delete from {Table} " +
                    $"where id = {id}"; ;

        ExecuteQuery(query);
    }

    public void Add(Location sponsor)
    {
        var query = $"insert into {Table} (name)" +
            $"values ({sponsor.Name});";

        ExecuteQuery(query);
    }

    public Location[] GetArray(LocationFilter filter)
    {
        var stringBuilder = new StringBuilder($"select * from {Table}");

        if (string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($"where name like %{filter.Search}%");

        stringBuilder.Append(';');


        return ExecuteGettingQuery(stringBuilder.ToString());
    }

    protected override Location Map(SqlDataReader sqlDataReader)
    {
        return new Location()
        {
            ID = sqlDataReader.GetInt32(0),
            Name = sqlDataReader.GetString(1),
        };
    }
}
