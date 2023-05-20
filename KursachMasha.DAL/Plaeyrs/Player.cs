using KursachMasha.DAL.Teams;

namespace KursachMasha.DAL.Players;




public class Player
{
    public int ID { get; set; }

    [ColumnHeadr("Имя")]
    public string Name { get; set; }

    [ColumnHeadr("Фамилия")]
    public string Surname { get; set; }
    
    [ColumnHeadr("Отчество")]
    public string Patronymic { get; set; }

    [ColumnHeadr("Номер в команде")]
    public int Number { get; set; }

    public int TeamID { get; set; }

    [ColumnHeadr("Команда")]
    public string TeamName { get; set; }

    public int RoleID { get; set; }

    [ColumnHeadr("Роль")]
    public string RoleName { get; set; }

    public Team Team { get; set; }
}
