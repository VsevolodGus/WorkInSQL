using KursachMasha.DAL.Location;

namespace KursachMasha.Classes;
public class Stadium
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int LocationID { get; set; }
    public int Volume { get; set; }

    public Location Location { get; set; }
    public List<Match> Matches { get; set; }
}