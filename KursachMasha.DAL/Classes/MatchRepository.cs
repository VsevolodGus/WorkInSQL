//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Npgsql;

//namespace KursachMasha.DAL.Classes;

//public class MatchRepository :
//    SqlWorker<Match>
//    , ISqlWorkerEntity<Match, MatchFilter>
//{
//    protected override string Table => throw new NotImplementedException();

//    public class MatchRepository : base()
//        {}
//    { protected override Match Map(NpgsqlDataReader sqlDataReader)
//    {
//        throw new NotImplementedException();
//    }
//}

//    protected override string Table => "mathes";

//    public void Add(Match obj)
//    {
//        var query = $"insert into {Table} (name, datetime, team1_id, team1_name number_in_team, team_id, role_id)" +
//            $"values ('{obj.Name}', '{obj.Surname}', '{obj.Patronymic}', '{obj.Number}', {obj.TeamID}, {obj.RoleID});";

//    ExecuteQuery(query);
//    }

//}

