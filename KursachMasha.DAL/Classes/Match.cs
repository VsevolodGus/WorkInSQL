using KursachMasha.DAL.Stadiums;
using KursachMasha.DAL.Teams;

namespace KursachMasha.DAL.Classes;
public class Match
{
    public int ID { get; set; }
    public DateTime DateTime { get; set; }
    public int Team1ID { get; set; }
    public string Team1Name { get; set; }
    public int Team2ID { get; set; }
    public string Team2Name { get; set; }
    public string ResultTeam1 { get; set; }
    public string ResultTeam2 { get; set; }
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    public int StadiumID { get; set; }
    public Stadium Stadium { get; set; }
}
