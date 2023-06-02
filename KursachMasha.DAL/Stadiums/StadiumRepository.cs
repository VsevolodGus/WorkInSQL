using Npgsql;
using System.Text;

namespace KursachMasha.DAL.Stadiums;
public class StadiumRepository :
    SqlWorker<Stadium>
    , ISqlWorkerEntity<Stadium, StadiumFilter>
{
   public StadiumRepository() : base() 
   { }

   protected override string Table => "stadiums";

    public void Update(Stadium obj)
    {
        var query = $"update from {Table} " +
                        $"set " +
                        $"Name = {obj.Name}" +
                        $", location_id = {obj.LocationID}" +
                    $"where id = {obj.ID};";

        ExecuteQuery(query);
    }

    public void Add(Stadium obj)
    {
        var query = $"insert into {Table} (name, volume, location_id)" +
            $"values ('{obj.Name}', '{obj.Volume}', {obj.LocationID});";

        ExecuteQuery(query);
    }

    public Stadium[] GetArray(StadiumFilter filter)
    {
        if (filter is null)
            filter = new StadiumFilter();

           var stringBuilder = new StringBuilder($"select s.id\r\n" +
            ", s.name\r\n" +
            ", s.volume\r\n" +
            ", location_id\r\n" +
            ", l.name\r\n" +
            ", CASE\r\n    WHEN  volume > 0 AND volume <= 1000 THEN 'Небольшой'\r\n" +
            "              WHEN  volume > 0 AND volume <= 1000 THEN 'Небольшой'\r\n" +
            "              WHEN  volume > 1000 AND volume <= 5000 THEN 'Средний'\r\n" +
            "              WHEN  volume > 5000 THEN 'Огромный'\r\n" +
            "              ELSE 'Не используется'\r\n    " +
            "              end as Size\r\n" +
            ", CASE\r\n    WHEN  get_count_matches_by_stadium_id(s.id) > 0\r\n and get_count_matches_by_stadium_id(s.id) < 5\r\n" +
            "                         THEN 'Не популярный'\r\n" +
            "              WHEN  get_count_matches_by_stadium_id(s.id) >= 5\r\n " +
            "                         THEN 'Популярный'\r\n    " +
            "              ELSE 'Заброшен'  \r\n    " +
            "              end as Popular\r\n" +
            $"from {Table} s\r\n" +
            $"INNER JOIN public.locations l ON s.location_id = l.id \r\n" +
            "where 1 = 1");


        if (!string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($"\n\tand s.name like '%{filter.Search}%'");

        if (filter.LocationID.HasValue)
            stringBuilder.Append($"\n\tand s.location_id = {filter.LocationID}");

        if (filter.IsUse)
            stringBuilder.Append($"\n\tand s.id = ANY(select m.stadium_id from matches m) ");

        
        stringBuilder.Append(';');
        var sql = stringBuilder.ToString();
        return base.ExecuteGetArrayQuery(sql); 
    }

    protected override Stadium Map(NpgsqlDataReader sqlDataReader)
    {
        return new Stadium()
        {
            ID = sqlDataReader.GetInt32(0),
            Name = sqlDataReader.GetString(1),
            Volume = sqlDataReader.GetInt32(2),
            LocationID = sqlDataReader.GetInt32(3),
            LocationName = sqlDataReader.GetString(4),
            Size = sqlDataReader.GetString(5),
            Popular = sqlDataReader.GetString(6),
        };
    }

    public Stadium GetByID(int id)
    {
        var query = "select s.id\r\n" +
            ", s.name\r\n" +
            ", s.volume\r\n" +
            ", location_id\r\n" +
            ", l.name\r\n" +
            ", CASE\r\n    WHEN  volume > 0 AND volume <= 1000 THEN 'Небольшой'\r\n" +
            "              WHEN  volume > 0 AND volume <= 1000 THEN 'Небольшой'\r\n" +
            "              WHEN  volume > 1000 AND volume <= 5000 THEN 'Средний'\r\n" +
            "              WHEN  volume > 5000 THEN 'Огромный'\r\n" +
            "              ELSE 'Не используется'\r\n    " +
            "              end as Size\r\n" +
            ", CASE\r\n    WHEN  get_count_matches_by_stadium_id(s.id) > 0\r\n and get_count_matches_by_stadium_id(s.id) < 5\r\n" +
            "                         THEN 'Не популярный'\r\n" +
            "              WHEN  get_count_matches_by_stadium_id(s.id) >= 5\r\n " +
            "                         THEN 'Популярный'\r\n    " +
            "              ELSE 'Заброшен'  \r\n    " +
            "              end as Popular\r\n" +
            $"from {Table} s\r\n" +
            $"INNER JOIN locations l ON s.location_id = l.id \r\n" +
            $"\r\n\twhere s.id = {id}";

       return base.ExecuteGetQuery(query);   
    }

}
