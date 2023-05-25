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

           var stringBuilder = new StringBuilder($"SELECT " +
            $"s.id, s.name, s.volume, s.location_id, l.name " +
            $"\r\n\tFROM public.stadiums s" +
            $"\r\n\tINNER JOIN public.locations l ON s.location_id = l.id " +
            $"\r\n\twhere 1 = 1");

        if (!string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($"\nand p.name like '%{filter.Search}%'");

        if (filter.LocationID.HasValue)
            stringBuilder.Append($"\nand p.team_id = {filter.LocationID}");


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
        };
    }

    public Stadium GetByID(int id)
    {
        var query = "SELECT " +
            $"s.id, s.name, s.volume, s.location_id, l.name " +
            $"\r\n\tFROM public.stadiums s" +
            $"\r\n\tINNER JOIN public.locations l ON s.location_id = l.id " +
            $"\r\n\twhere s.id = {id}";

       return base.ExecuteGetQuery(query);   
    }

}
