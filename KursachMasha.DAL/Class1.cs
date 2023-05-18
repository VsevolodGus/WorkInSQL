using KursachMasha.Classes;
using KursachMasha.DAL.Players;
using KursachMasha.DAL.Sponsors;
using KursachMasha.DAL.Locations;

namespace KursachMasha.DAL;
internal class Class1
{
    public List<Player> PlayerList { get; set; }
    public List<Team> TeamList { get; set; }
    public List<Sponsor> SponsorList { get; set; }
    public List<Match> MatchList { get; set; }
    public List<Stadium> StadiumList { get; set; }
    public List<Location> LocationList { get; set; }

    /// <summary>
    /// View
    /// </summary>
    public void SecondQuery()
    {
        //TODO обернуть во VIEW
        PlayerList.Select(c => new
        {
            Player = c,
            //RoleName = c.ID == 1 ? "ata": c.ID == 2 ? "protec",
            TeamName = c.Team.Name,
            SponsorName = c.Team.Sponsor.Name,
        });
    }

    public void ThirdQuery()
    {

    }

    public void FivethQuery()
    {

    }

    //TODO GROUP by Having
    public void FourthQuery()
    {
        //TODO передалать, чтобы можно было получать данные игрока
        PlayerList.GroupBy(c => c.ID)
            .Select(c => new
            {
                ID = c.Key,
                Count = c.SelectMany(v => v.Team.Matches).Count(),
            })
            .Where(c => c.Count > 10);
    }

}
