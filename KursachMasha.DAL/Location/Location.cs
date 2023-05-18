using KursachMasha.Classes;

namespace KursachMasha.DAL.Location;
public class Location
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<Stadium> Stadiums { get; set; }
}