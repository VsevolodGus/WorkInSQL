using Npgsql;

namespace KursachMasha.DAL.Queries;
public class DataPlayersMatchesQuery
{
    private readonly NpgsqlConnection sqlConnection;
    public DataPlayersMatchesQuery()
    {
        sqlConnection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Database=postgres; Password=postgres;");
    }

    
    public PlayerMatches[] Execute()
    {
        var query = "select " +
            "\r\n\tp.id" +
            "\r\n\t, p.name" +
            "\r\n\t, p.surname" +
            "\r\n\t, p.patronymic" +
            "\r\n\t,  COUNT(*) " +
            "\r\nfrom matches m " +
            "\r\n\tINNER JOIN teams t ON t.id = m.team1_id or t.id = m.team2_id" +
            "\r\n\tINNER JOIN players p ON t.id = p.team_id" +
            "\r\nGROUP by p.id" +
            "\r\nHAVING count(*) > 0;";

        sqlConnection.Open();
        var reader = new NpgsqlCommand(query, sqlConnection).ExecuteReader();
        
        var result = new List<PlayerMatches>();
        while (reader.Read())
        {
            result.Add(new PlayerMatches
            {
                ID = reader.GetInt32(0),
                Name = reader.GetString(1),
                Surname = reader.GetString(2),
                Patronymic = reader.GetString(3),
                CountMatches = reader.GetInt32(4),
            });
        }

        reader.Close();
        sqlConnection.Close();

        return result.ToArray();
    }
}

public class PlayerMatches
{
    public int ID { get; init; }

    [ColumnHeadr("Имя")]
    public string Name { get; set; }

    [ColumnHeadr("Фамилия")]
    public string Surname { get; set; }

    [ColumnHeadr("Отчество")]
    public string Patronymic { get; set; }

    [ColumnHeadr("Кол-во матчей")]
    public int CountMatches { get; set; }
}