using System.Collections.Generic;
using System.Data.SqlClient;

namespace KursachMasha.DAL;
public abstract class SqlWorker<T>
{
    protected readonly SqlConnection sqlConnection;
    protected abstract string Table { get; }
    public SqlWorker()
    {
        sqlConnection = new SqlConnection();
        sqlConnection.Open();
    }

    protected void ExecuteQuery(string deletetQuety)
    {
        SqlCommand command = new SqlCommand(deletetQuety, sqlConnection);

        command.ExecuteNonQuery();
    }

    protected T[] ExecuteGettingQuery(string gettingQuery)
    {
        var command = new SqlCommand(gettingQuery, sqlConnection);
        var reader = command.ExecuteReader();

        var result = new List<T>();
        while (reader.Read())
            result.Add(Map(reader));

        reader.Close();

        return result.ToArray();
    }

    protected abstract T Map(SqlDataReader sqlDataReader);
}
