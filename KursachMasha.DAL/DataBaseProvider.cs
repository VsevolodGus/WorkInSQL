using Npgsql;

namespace KursachMasha.DAL;
internal class DataBaseProvider
{
    public readonly NpgsqlConnection SqlConnection;

    public DataBaseProvider()
    {
        SqlConnection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Database=kursach; Password=1;");
    }
}
