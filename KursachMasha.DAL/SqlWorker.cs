using Npgsql;

namespace KursachMasha.DAL;
public abstract class SqlWorker<T>
{
    private readonly DataBaseProvider provider;
    protected abstract string Table { get; }
    public SqlWorker()
    {
        provider = new DataBaseProvider();
    }
    public void Delete(int id)
    {
        var query = $"delete from {Table} " +
                    $"where id = {id}";

        ExecuteQuery(query);
    }

    public void Delete(int[] ids)
    {
        var query = $"delete from {Table} " +
                    $"where id in ({string.Join(',', ids)})";

        ExecuteQuery(query);
    }

    protected void ExecuteQuery(string query)
    {
        provider.SqlConnection.Open();
        var command = new NpgsqlCommand(query, provider.SqlConnection);
        command.ExecuteNonQuery();

        provider.SqlConnection.Close();
    }

    protected T[] ExecuteGetArrayQuery(string gettingQuery)
    {
        provider.SqlConnection.Open();

        var command = new NpgsqlCommand(gettingQuery, provider.SqlConnection);
        var reader = command.ExecuteReader();

        var result = new List<T>();
        while (reader.Read())
            result.Add(Map(reader));

        reader.Close();
        provider.SqlConnection.Close();

        return result.ToArray();
    }

    protected T ExecuteGetQuery(string gettingQuery)
    {
        provider.SqlConnection.Open();

        var command = new NpgsqlCommand(gettingQuery, provider.SqlConnection);
        var reader = command.ExecuteReader();

        reader.Read();
        var result = Map(reader);
        reader.Close();
        provider.SqlConnection.Close();

        return result;
    }



    protected abstract T Map(NpgsqlDataReader sqlDataReader);
}
