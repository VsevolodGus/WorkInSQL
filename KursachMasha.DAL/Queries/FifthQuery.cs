using KursachMasha.Classes;
using System.Data.SqlClient;

namespace KursachMasha.DAL.Queries;

internal class FifthQuery
{
    
    protected readonly SqlConnection sqlConnection;
    public FifthQuery()
    {
        sqlConnection = new SqlConnection();
        sqlConnection.Open();
    }

    /// <summary>
    /// SponsorList.Where(c => c.Teams.All(v => v.Matches.Any(d => d.StadiumID == 1)));
    /// </summary>
    public void Execute(int stadiumID) 
    {
        var query = "select s.* from sponsors s " +
            "inner join teams t ON t.sponsor_id = s.id " +
            "inner join matches m ON m.teamd1_id = t.id OR m.teamd2_id = t.id " +
            $"where m.stadium_id = {stadiumID}";

        new SqlCommand(query, sqlConnection).ExecuteNonQuery();
    }

}
