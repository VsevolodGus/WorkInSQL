﻿//using Npgsql;
//using System.Text;

//namespace KursachMasha.DAL.Locations;
//public class LocationRepository :
//    SqlWorker<Location>
//    , ISqlWorkerEntity<Location, LocationFilter>
//{
//    public LocationRepository() : base()
//    { }

//    protected override string Table => "locations";

//    public void Update(Location sponsor)
//    {
//        var query = $"update from {Table} " +
//                        $"SET " +
//                        $"Name = {sponsor.Name}" +
//                    $"where id = {sponsor.ID};";

//        ExecuteQuery(query);
//    }

//    public void Delete(int id)
//    {
//        var query = $"delete from {Table} " +
//                    $"where id = {id}"; ;

//        ExecuteQuery(query);
//    }

//    public void Add(Location sponsor)
//    {
//        var query = $"insert into {Table} (name)" +
//            $"values ({sponsor.Name});";

//        ExecuteQuery(query);
//    }

//    public Location[] GetArray(LocationFilter filter)
//    {
//        var stringBuilder = new StringBuilder($"select * from {Table}");

//        if (string.IsNullOrEmpty(filter.Search))
//            stringBuilder.Append($"where name like %{filter.Search}%");

//        stringBuilder.Append(';');


//        return ExecuteGetArrayQuery(stringBuilder.ToString());
//    }

//    protected override Location Map(NpgsqlDataReader sqlDataReader)
//    {
//        return new Location()
//        {
//            ID = sqlDataReader.GetInt32(0),
//            Name = sqlDataReader.GetString(1),
//        };
//    }

//    public Location GetByID(int id)
//    {
//        throw new NotImplementedException();
//    }
//}