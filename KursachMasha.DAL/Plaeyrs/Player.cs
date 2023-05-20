using KursachMasha.DAL.Teams;

namespace KursachMasha.DAL.Players;




public class Player
{
    public int ID { get; set; }

    [Column("Имя")]
    public string Name { get; set; }

    [Column("Фамилия")]
    public string Surname { get; set; }
    
    [Column("Отчество")]
    public string Patronymic { get; set; }

    [Column("Номер в команде")]
    public int Number { get; set; }

    public int TeamID { get; set; }

    [Column("Команда")]
    public string TeamName { get; set; }

    public int RoleID { get; set; }

    [Column("Роль")]
    public string RoleName { get; set; }

    public Team Team { get; set; }
}
