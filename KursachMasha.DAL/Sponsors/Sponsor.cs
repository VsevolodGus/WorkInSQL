using KursachMasha.DAL.Teams;

namespace KursachMasha.DAL.Sponsors;
public class Sponsor
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Team> Teams { get; set; }
}
