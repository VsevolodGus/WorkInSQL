using Npgsql;

namespace KursachMasha.DAL;
public abstract class SqlWorker<T>
{
    private readonly NpgsqlConnection sqlConnection;
    protected abstract string Table { get; }
    public SqlWorker()
    {
        sqlConnection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Database=postgres; Password=postgres;");
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
                    $"where id in ({string.Join(',',ids)})";

        ExecuteQuery(query);
    }

    protected void ExecuteQuery(string query)
    {
        sqlConnection.Open();
        var command = new NpgsqlCommand(query, sqlConnection);
        command.ExecuteNonQuery();

        sqlConnection.Close();
    }

    protected T[] ExecuteGetArrayQuery(string gettingQuery)
    {
        sqlConnection.Open();

        var command = new NpgsqlCommand(gettingQuery, sqlConnection);
        var reader = command.ExecuteReader();

        var result = new List<T>();
        while (reader.Read())
            result.Add(Map(reader));

        reader.Close();
        sqlConnection.Close();

        return result.ToArray();
    }

    protected T ExecuteGetQuery(string gettingQuery)
    {
        sqlConnection.Open();

        var command = new NpgsqlCommand(gettingQuery, sqlConnection);
        var reader = command.ExecuteReader();

        reader.Read();
        var result = Map(reader);
        reader.Close();
        sqlConnection.Close();

        return result;
    }

   

    protected abstract T Map(NpgsqlDataReader sqlDataReader);
}
