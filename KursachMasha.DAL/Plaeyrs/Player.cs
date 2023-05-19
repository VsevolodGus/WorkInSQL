using KursachMasha.Classes;

namespace KursachMasha.DAL.Players;

public class Player
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public int Number { get; set; }
    public int TeamID { get; set; }
    public int RoleID { get; set; }
    public Team Team { get; set; }
}
