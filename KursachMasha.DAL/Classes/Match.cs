using KursachMasha.DAL.Teams;

namespace KursachMasha.Classes;
public class Match
{
    public int ID { get; set; }
    public DateTime DateTime { get; set; }
    public int Team1ID { get; set; }
    public int Team2ID { get; set; }
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    public int StadiumID { get; set; }
    public Stadium Stadium { get; set; }
}
