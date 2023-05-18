using KursachMasha.Classes;

namespace KursachMasha.DAL.Players;

public class Player
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int TeamID { get; set; }
    public string Description { get; set; }
    public Team Team { get; set; }
}
