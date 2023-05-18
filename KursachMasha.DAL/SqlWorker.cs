using System.Data.SqlClient;

namespace KursachMasha.DAL;
public abstract class SqlWorker<T>
{
    protected readonly SqlConnection sqlConnection;
    protected abstract string Table { get; }
    public SqlWorker()
    {
        sqlConnection = new SqlConnection("");
    }

    protected void ExecuteQuery(string query)
    {
        sqlConnection.Open();

        var command = new SqlCommand(query, sqlConnection);
        command.ExecuteNonQuery();

        sqlConnection.Close();
    }

    protected T[] ExecuteGettingQuery(string gettingQuery)
    {
        sqlConnection.Open();

        var command = new SqlCommand(gettingQuery, sqlConnection);
        var reader = command.ExecuteReader();

        var result = new List<T>();
        while (reader.Read())
            result.Add(Map(reader));

        reader.Close();
        sqlConnection.Close();

        return result.ToArray();
    }

    protected abstract T Map(SqlDataReader sqlDataReader);
}
