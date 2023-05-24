using KursachMasha.DAL.Stadiums;

namespace KursachMasha.DAL.Locations;
public class MyLocation
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<Stadium> Stadiums { get; set; }
}