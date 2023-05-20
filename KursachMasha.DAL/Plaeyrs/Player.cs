using KursachMasha.DAL.Teams;

namespace KursachMasha.DAL.Players;


[AttributeUsage(AttributeTargets.Property)]
public class ColumnAttribute : Attribute
{
    public ColumnAttribute(string name)
    {
        Name = name;
    }
    
    public string Name { get; init; }
}

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

    [Column("Команда")]
    public int TeamID { get; set; }

    [Column("Роль")]
    public int RoleID { get; set; }
    
    public Team Team { get; set; }
}
