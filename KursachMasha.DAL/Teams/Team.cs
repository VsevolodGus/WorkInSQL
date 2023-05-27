using KursachMasha.DAL.Classes;
using KursachMasha.DAL.Players;
using KursachMasha.DAL.Sponsors;

namespace KursachMasha.DAL.Teams;
public class Team
{
    public int ID { get; set; }
    [ColumnHeadr("Название")]
    public string Name { get; set; }
    public int SponsorID { get; set; }
    [ColumnHeadr("Спонсор")]
    public string SponsorName { get; set; }
    public Sponsor Sponsor { get; set; }
    public List<Player> Players { get; set; }
    public List<Match> Matches { get; set; }

}