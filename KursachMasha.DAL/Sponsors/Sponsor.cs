namespace KursachMasha.DAL.Sponsors;
public class Sponsor
{
    public int ID { get; set; }
    [ColumnHeadr("Наименование спонсора")]
    public string Name { get; set; }

    [ColumnHeadr("Описание")]
    public string Description { get; set; }
}
