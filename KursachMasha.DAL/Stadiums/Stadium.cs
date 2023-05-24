using KursachMasha.Classes;
using KursachMasha.DAL.Locations;

namespace KursachMasha.DAL.Stadiums;
public class Stadium
{
    public int ID { get; set; }

    [ColumnHeadr("Название")]
    public string Name { get; set; }

    [ColumnHeadr("Размер")]
    public int Volume { get; set; }
    public int? LocationID { get; set; }

    [ColumnHeadr("Город")]
    public string LocationName { get; set; }
    public MyLocation Location { get; set; }
    public List<Match> Matches { get; set; }
}