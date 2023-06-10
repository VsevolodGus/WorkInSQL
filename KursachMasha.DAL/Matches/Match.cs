namespace KursachMasha.DAL.Mathes;
public class Match
{

    public Match()
    {
        DateTime = DateTime.Now;
    }
    public int ID { get; set; }

    [ColumnHeadr("Дата")]
    public DateTime DateTime { get; set; }

    public int Team1ID { get; set; }

    [ColumnHeadr("Команда 1")]
    public string Team1Name { get; set; }

    public int Team2ID { get; set; }

    [ColumnHeadr("Команда 2")]
    public string Team2Name { get; set; }

    public int StadiumID { get; set; }

    [ColumnHeadr("Стадион")]
    public string StadiumName { get; set; }

    [ColumnHeadr("Результат команды 1")]
    public int? ResultTeam1 { get; set; }

    [ColumnHeadr("Результат команды 2")]
    public int? ResultTeam2 { get; set; }
}
