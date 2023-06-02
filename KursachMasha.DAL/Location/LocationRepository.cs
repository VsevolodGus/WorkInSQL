using Npgsql;
using System.Text;

namespace KursachMasha.DAL.Locations;
public class LocationRepository :
    SqlWorker<MyLocation>
    , ISqlWorkerEntity<MyLocation, LocationFilter>
{
    public LocationRepository() : base()
    { }

    protected override string Table => "locations";

    public void Update(MyLocation obj)
    {
        var query = $"update from {Table} " +
                        $"SET " +
                        $"Name = {obj.Name}" +
                    $"where id = {obj.ID};";

        ExecuteQuery(query);
    }

    public void Delete(int id)
    {
        var query = $"delete from {Table} " +
                    $"where id = {id}"; ;

        ExecuteQuery(query);
    }

    public void Add(MyLocation obj)
    {
        var query = $"insert into {Table} (name)" +
            $"values ({obj.Name});";

        ExecuteQuery(query);
    }

    public MyLocation[] GetArray(LocationFilter filter)
    {
        var stringBuilder = new StringBuilder($"select * from {Table}");

        if (!string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($"\nwhere name like '%{filter.Search}%'");

        stringBuilder.Append(';');


        return ExecuteGetArrayQuery(stringBuilder.ToString());
    }

    protected override MyLocation Map(NpgsqlDataReader sqlDataReader)
    {
        return new MyLocation()
        {
            ID = sqlDataReader.GetInt32(0),
            Name = sqlDataReader.GetString(1),
        };
    }

    public MyLocation GetByID(int id)
    {
        var query = $"select * from {Table}" +
            $"\n\twhere id = {id};";

        return ExecuteGetQuery(query);
    }
}
