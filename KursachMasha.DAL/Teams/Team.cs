namespace KursachMasha.DAL.Teams;
public class Team
{
    public int ID { get; set; }
    [ColumnHeadr("Название")]
    public string Name { get; set; }
    public int SponsorID { get; set; }
    [ColumnHeadr("Спонсор")]
    public string SponsorName { get; set; }

}