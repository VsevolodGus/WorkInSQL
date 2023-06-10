namespace KursachMasha.DAL.Stadiums;
public class Stadium
{
    public int ID { get; set; }

    [ColumnHeadr("Название")]
    public string Name { get; set; }

    [ColumnHeadr("Размер")]
    public int Volume { get; set; }
    [ColumnHeadr("Категория размера")]
    public string Size { get; set; }

    [ColumnHeadr("Популярность")]
    public string Popular { get; set; }
    public int? LocationID { get; set; }

    [ColumnHeadr("Город")]
    public string LocationName { get; set; }
}