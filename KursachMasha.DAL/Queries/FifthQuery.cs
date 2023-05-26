using KursachMasha.DAL.Stadiums;
using Npgsql;

namespace KursachMasha.DAL.Queries;

internal class FifthQuery
{
    protected readonly NpgsqlConnection sqlConnection;
    public FifthQuery()
    {
        sqlConnection = new NpgsqlConnection();
    }
    public void Execute(int stadiumID) 
    {
        var query = "select s.* from sponsors s " +
           "inner join teams t ON t.sponsor_id = s.id " +
           "inner join matches m ON m.teamd1_id = t.id OR m.teamd2_id = t.id " +
           $"where m.stadium_id = {stadiumID}";

        new NpgsqlCommand(query, sqlConnection).ExecuteNonQuery();

    }

}
