using Npgsql;
using System.Data.SqlClient;

namespace KursachMasha.DAL;
public abstract class SqlWorker<T>
{
    protected readonly NpgsqlConnection sqlConnection;
    protected abstract string Table { get; }
    public SqlWorker()
    {
        sqlConnection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Database=kursach; Password=1;");
    }

    protected void ExecuteQuery(string query)
    {
        sqlConnection.Open();
        var command = new NpgsqlCommand(query, sqlConnection);
        command.ExecuteNonQuery();

        sqlConnection.Close();
    }

    protected T[] ExecuteGettingQuery(string gettingQuery)
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

    protected abstract T Map(NpgsqlDataReader sqlDataReader);
}
